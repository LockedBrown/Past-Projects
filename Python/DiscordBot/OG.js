const { Client, Attachment } = require("discord.js");

const bot = new Client();
const ytdl = require("ytdl-core");

const token = ""; // DISCORD TOKEN TO API LOGIN

const PREFIX = ".";

var version = "1.5";

var servers = {};

bot.on("ready", () => {
	console.log(`Logged in, V: ` + version);
});

bot.on("message", (message) => {
	if (message.content.substring().charAt(0) == ".") {
		let args = message.content.substring(PREFIX.length).split(" ");

		switch (args[0]) {
			case "help":
				message.reply(
					"Commands available: play, skip, stop, avatar, corona, and clear."
				);
				break;
			case "commands":
				message.reply(
					"Commands available: play, skip, stop, avatar, corona, and clear."
				);
				break;
			case "play":
				function play(connection, message) {
					var server = servers[message.guild.id];
					server.dispatcher = connection.play(
						ytdl(server.queue[0], { filter: "audioonly" })
					);
					server.queue.shift();
					server.dispatcher.on("end", function () {
						if (server.queue[0]) {
							console.log("[0]");
							play(connection, message);
						} else {
							connection.disconnect();
						}
					});
				}

				if (!args[1]) {
					message.channel.send("you need to provide a link!");
					console.log("no link");
					return;
				}

				if (!message.member.voice.channel) {
					message.channel.send("you're not in a voice channel!");
					console.log("no channel");
					return;
				}

				if (!servers[message.guild.id]) {
					servers[message.guild.id] = {
						queue: [],
					};
				}

				var server = servers[message.guild.id];

				server.queue.push(args[1]);

				if (!message.guild.voiceConnection) {
					message.member.voice.channel.join().then(function (connection) {
						play(connection, message);
					});
				}

				break;

			case "skip":
				var server = servers[message.guild.id];
				if (server.dispatcher) server.dispatcher.end();
				message.channel.send("Skipping the song");
				console.log("skipping");
				break;

			case "stop":
				var server = servers[message.guild.id];
				if (message.guild.voice.connection) {
					for (var i = server.queue.length - 1; i >= 0; i--) {
						server.queue.splice(i, 1);
					}
					server.dispatcher.end();
					message.channel.send("Stopped the queue");
					console.log("stopped the queue");
				}
				if (message.guild.connection) {
					message.guild.voice.connection.disconnect();
				}

			case "clear":
				if (!args[1]) {
					return message.reply("Please put an amount");
				} else {
					message.channel.bulkDelete(args[1]);
				}
				break;

			case "avatar":
				message.reply(message.author.displayAvatarURL());
				break;

			case "corona":
				const puppeteer = require("puppeteer");

				async function scrapeCount(url) {
					message.channel.send("Fetching Information..");
					const browser = await puppeteer.launch();
					const page = await browser.newPage();

					await page.goto(url);

					const [overallEl] = await page.$x(
						"/html/body/div[3]/div[2]/div[1]/div/div[4]/div/span"
					);
					const overall = await (
						await overallEl.getProperty("textContent")
					).jsonValue();

					const [deathsEl] = await page.$x(
						"/html/body/div[3]/div[2]/div[1]/div/div[6]/div/span"
					);
					const deaths = await (
						await deathsEl.getProperty("textContent")
					).jsonValue();

					const [recoveredEl] = await page.$x(
						"/html/body/div[3]/div[2]/div[1]/div/div[7]/div/span"
					);
					const recovered = await (
						await recoveredEl.getProperty("textContent")
					).jsonValue();

					const [UKcountEl] = await page.$x(
						'//*[@id="main_table_countries_today"]/tbody[1]/tr[10]/td[3]'
					);
					const UKcount = await (
						await UKcountEl.getProperty("textContent")
					).jsonValue();

					const [UK_newCasesEl] = await page.$x(
						'//*[@id="main_table_countries_today"]/tbody[1]/tr[10]/td[4]'
					);
					const UK_newCases = await (
						await UK_newCasesEl.getProperty("textContent")
					).jsonValue();

					const [UK_deathsEl] = await page.$x(
						'//*[@id="main_table_countries_today"]/tbody[1]/tr[10]/td[5]'
					);
					const UK_deaths = await (
						await UK_deathsEl.getProperty("textContent")
					).jsonValue();

					const [UK_newDeathsEl] = await page.$x(
						'//*[@id="main_table_countries_today"]/tbody[1]/tr[10]/td[6]'
					);
					const UK_newDeaths = await (
						await UK_newDeathsEl.getProperty("textContent")
					).jsonValue();

					message.channel.send(
						`Corona cases : ${overall.trim()}\nDeaths: ${deaths.trim()}\nRecovered: ${recovered.trim()}\n\nUK Count: ${UKcount.trim()}\nUK total deaths: ${UK_deaths.trim()}\nUK todays cases: ${UK_newCases.trim()}\nUK todays deaths : ${UK_newDeaths.trim()}`
					);
					browser.close();
				}

				scrapeCount("https://www.worldometers.info/coronavirus/");
				break;
		}
	} else {
	}
});

bot.login(token);
