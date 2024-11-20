module.exports = {
	name: "news",
	description: "goes to hacker news and displays news in chat",
	execute(message, args) {
		const request = require("request");
		const cheerio = require("cheerio");

		request("https://news.ycombinator.com/", (error, response, html) => {
			if (!error && response.statusCode == 200) {
				const $ = cheerio.load(html);

				$(".title").each((i, el) => {
					var name = $(el).text();
					const link = $(el).find("a").attr("href");
					if (link == null) {
					} else {
						if (
							name.includes("hackers") == true ||
							name.includes("javascript") == true ||
							name.includes("programming") == true ||
							name.includes("programmer") == true ||
							name.includes("web browser") == true ||
							name.includes("space") == true ||
							name.includes("SpaceX") == true ||
							name.includes("spaceX") == true
						) {
							message.channel.send(`${name}, Link: ${link}`);
						} else {
						}
					}
				});
			}
		});
	},
};
