module.exports = {
	name: "film",
	description: "sends link to film requested",
	execute(message, args) {
		var links = [
			"https://putlockers.bz/search?q=",
			"https://www5.123moviesfree.sc/search-query/",
			"http://sharemega.com/search-movies/",
			"https://ww1.124movies.to/?s=",
			"https://gomovies-online.me/search/",
		];

		for (let i = 0; i < links.length; i++) {
			if (i == 2) {
				message.channel.send(links[i] + args[1] + ".html\n");
			} else {
				message.channel.send(links[i] + args[1] + "\n");
			}
		}
	},
};
