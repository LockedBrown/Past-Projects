module.exports = {
	name: "help",
	description: "sends commands",
	execute(message, args) {
		message.channel.send(
			"Commands available:\nplay: play / queue a song\nskip: skips a song\nstop: stops the songs\navatar: @someone and it will show there image\nprice: type a game to find the cheapest price(use + instead of spaces)\ncorona: to get data on infected / deaths / new cases ect..\nclear: clear + amount to delete message from channel\nfilm: gives you the links of films to watch them, you gotta provide the name(for spaces in the films name use + instead)\nfilm-list: give a IMDB list to get the bot to show you name and rating, if no list is given then default will be top 2020 movies\nimage: provide an name, and the bot will respond with an image related that it has gotten from google"
		);
	},
};
