module.exports = {
	name: "image",
	description: "gets a random image on gimages from args",
	execute(message, args, serverQueue) {
		const request = require("request");
		const cheerio = require("cheerio");
		function image(message, args) {
			var options = {
				url: "http://results.dogpile.com/serp?qc=images&q=" + args,
				method: "GET",
				headers: {
					Accept: "text/html",
					"User-Agent": "Chrome",
				},
			};

			request(options, function (error, response, responseBody) {
				if (error) {
					return;
				}

				$ = cheerio.load(responseBody);

				var links = $(".image a.link");

				var urls = new Array(links.length)
					.fill(0)
					.map((v, i) => links.eq(i).attr("href"));

				if (!urls.length) {
					return;
				}

				// Send result
				message.channel.send(urls[Math.floor(Math.random() * urls.length)]);
			});
		}

		image(message, args);
	},
};
