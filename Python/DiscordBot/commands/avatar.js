module.exports = {
	name: "avatar",
	description: "shows user picture (can also mention users)",
	execute(message, args) {
		if (!message.mentions.users.size) {
			message.reply(user.displayAvatarURL());
		}

		const avatarList = message.mentions.users.map((user) => {
			message.reply(user.displayAvatarURL());
		});
	},
};
