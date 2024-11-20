module.exports = {
	name: "film-list",
	description: "lists top films",
	execute(message, args, serverQueue) {
		const request = require("request");
		const cheerio = require("cheerio");

		if (!args[1]) {
			args[1] =
				"https://www.imdb.com/search/title/?year=2020&title_type=feature&";
			message.channel.send(
				"If you provide an IMDB list then i can show you those, but for now i will use the 2020 top movies"
			);
		}
		request(args[1], (error, response, html) => {
			if (!error && response.statusCode == 200) {
				const $ = cheerio.load(html);

				$(".lister-item").each((i, el) => {
					const name = $(el).find(".lister-item-header").find("a").text();
					const rating = $(el).find(".ratings-bar").find("strong").text();
					message.channel.send(
						`No. ${i + 1}, Film: ${name.trim()}, Rating: ${rating.trim()}`
					);
				});
			}
		});
	},
};
