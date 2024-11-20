const Discord = require("discord.js");
const { Client, Attachment, MessageEmbed } = require("discord.js");
const client = new Discord.Client();
const ytdl = require("ytdl-core");

const token = ""; // DISCORD API LOGIN TOKEN

prefix = ".";

const queue = new Map();
const fs = require("fs");

client.commands = new Discord.Collection().filter((file) =>
  file.endsWith(".js")
);
const commandFiles = fs.readdirSync("./commands/");
for (const file of commandFiles) {
  const command = require(`./commands/${file}`);

  client.commands.set(command.name, command);
}

client.once("ready", () => {
  console.log("Ready!");
});

client.once("reconnecting", () => {
  console.log("Reconnecting!");
});

client.once("disconnect", () => {
  console.log("Disconnect!");
});

client.on("message", async (message) => {
  if (message.author.bot) return;
  if (!message.content.startsWith(prefix)) return;

  writeUpUser(message.author.username, message);

  const serverQueue = queue.get(message.guild.id);
  let args = message.content.substring(prefix.length).split(" ");

  /* Play */ if (message.content.startsWith(`${prefix}play`)) {
    execute(message, serverQueue);
    return;
  } /* Skip */ else if (message.content.startsWith(`${prefix}skip`)) {
    client.commands.get("skip").execute(message, args, serverQueue);
  } /* Stop */ else if (message.content.startsWith(`${prefix}stop`)) {
    client.commands.get("stop").execute(message, args, serverQueue);
  } /* Help */ else if (message.content.startsWith(`${prefix}help`)) {
    client.commands.get("help").execute(message, args);
  } /* Clear */ else if (message.content.startsWith(`${prefix}clear`)) {
    client.commands.get("clear").execute(message, args);
  } /* Avatar */ else if (message.content.startsWith(`${prefix}avatar`)) {
    client.commands.get("avatar").execute(message, args);
  } /* Corona */ else if (message.content.startsWith(`${prefix}corona`)) {
    client.commands.get("corona").execute(message, args);
  } /* Price */ else if (message.content.startsWith(`${prefix}price`)) {
    client.commands.get("price").execute(message, args);
  } /* Film list */ else if (message.content.startsWith(`${prefix}film-list`)) {
    client.commands.get("film-list").execute(message, args);
  } /* Image */ else if (message.content.startsWith(`${prefix}image`)) {
    client.commands.get("image").execute(message, args);
  } /* Film links */ else if (message.content.startsWith(`${prefix}film`)) {
    client.commands.get("film").execute(message, args);
  } /* News */ else if (message.content.startsWith(`${prefix}news`)) {
    client.commands.get("news").execute(message, args);
  } else {
    message.channel.send("You need to enter a valid command!");
  }
});

async function execute(message, serverQueue) {
  const args = message.content.split(" ");

  const voiceChannel = message.member.voice.channel;
  if (!voiceChannel)
    return message.channel.send(
      "You need to be in a voice channel to play music!"
    );
  const permissions = voiceChannel.permissionsFor(message.client.user);
  if (!permissions.has("CONNECT") || !permissions.has("SPEAK")) {
    return message.channel.send(
      "I need the permissions to join and speak in your voice channel!"
    );
  }

  const songInfo = await ytdl.getInfo(args[1]);
  const song = {
    title: songInfo.title,
    url: songInfo.video_url,
  };

  if (!serverQueue) {
    const queueContruct = {
      textChannel: message.channel,
      voiceChannel: voiceChannel,
      connection: null,
      songs: [],
      volume: 5,
      playing: true,
    };

    queue.set(message.guild.id, queueContruct);

    queueContruct.songs.push(song);

    try {
      var connection = await voiceChannel.join();
      queueContruct.connection = connection;
      play(message.guild, queueContruct.songs[0]);
    } catch (err) {
      console.log(err);
      queue.delete(message.guild.id);
      return message.channel.send(err);
    }
  } else {
    serverQueue.songs.push(song);
    return message.channel.send(`${song.title} has been added to the queue!`);
  }
}

function writeUpUser(user, command) {
  var date = new Date();
  var current_hour = date.getHours();
  var current_min = date.getMinutes();
  fs.appendFile(
    "C:\\Users\\Billy\\Desktop\\Coding\\Python\\Python\\DiscordBot\\log.txt",
    `${user} used ${command}: ${getDateTime()}\n`,
    function (err) {
      if (err) {
        return console.log(err);
      }
      console.log("The file was saved!");
    }
  );
}

function getDateTime() {
  var date = new Date();
  var hour = date.getHours();
  hour = (hour < 10 ? "0" : "") + hour;
  var min = date.getMinutes();
  min = (min < 10 ? "0" : "") + min;
  var sec = date.getSeconds();
  sec = (sec < 10 ? "0" : "") + sec;
  var year = date.getFullYear();
  var month = date.getMonth() + 1;
  month = (month < 10 ? "0" : "") + month;
  var day = date.getDate();
  day = (day < 10 ? "0" : "") + day;
  return (
    "Date: " +
    year +
    ":" +
    month +
    ":" +
    day +
    ", Time: " +
    hour +
    ":" +
    min +
    ":" +
    sec
  );
}

function play(guild, song) {
  const serverQueue = queue.get(guild.id);
  if (!song) {
    serverQueue.voiceChannel.leave();
    queue.delete(guild.id);
    return;
  }

  const dispatcher = serverQueue.connection
    .play(ytdl(song.url))
    .on("finish", () => {
      serverQueue.songs.shift();
      play(guild, serverQueue.songs[0]);
    })
    .on("error", (error) => console.error(error));
  dispatcher.setVolumeLogarithmic(serverQueue.volume / 5);
  serverQueue.textChannel.send(`Start playing: **${song.title}**`);
}

client.login(token);
