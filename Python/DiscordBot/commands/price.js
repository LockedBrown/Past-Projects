module.exports = {
	name: "price",
	description:
		"downloads html of url + arg, then gets price of game and responds with link and price",
	execute(message, args, serverQueue) {
		const request = require("request");
		const cheerio = require("cheerio");
		request(
			"https://www.allkeyshop.com/blog/catalogue/search-" + args[1],
			(error, response, html) => {
				if (!error && response.statusCode == 200) {
					const $ = cheerio.load(html);

					const Elements = $(".search-results-row");

					$(".search-results-row-link").each((i, el) => {
						const item = $(el).text();
						const link = $(el).attr("href");
						const name = $(el).find(".search-results-row-game-title").text();
						const price = $(el).find(".search-results-row-price").text();

						if (i == 0) {
							request(link, (error1, response1, html1) => {
								if (!error1 && response1.statusCode == 200) {
									const $$ = cheerio.load(html1);

									$$(".offers-table-row").each((i1, el1) => {
										let mainLink = $$(el1).find(".buy-btn").attr("href");
										const Lowprice = $$(el1).find(".price").text();
										mainLink = mainLink.substring(2);
										if (i1 == 0) {
											message.channel.send(
												"Name: " +
													name.trim() +
													`\nPrice: £${
														parseInt(Lowprice.trim(), 10) * 0.9
													} / ` +
													Lowprice.trim() +
													"\nLink to buy: " +
													mainLink +
													"\nLink to comparison: " +
													link
											);
										}
									});
								}
							});
						}
					});
				}
			}
		);
	},
};
