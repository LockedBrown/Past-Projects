module.exports = {
	name: "clear",
	description: "clears messages",
	execute(message, args) {
		if (!args[1]) {
			return message.reply("Please put an amount");
		} else {
			message.channel.bulkDelete(args[1]);
		}
	},
};
