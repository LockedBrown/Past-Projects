module.exports = {
	name: "corona",
	description: "gets corona info from website about cases",
	execute(message, args) {
		const puppeteer = require("puppeteer");
		async function scrapeCount(message, url) {
			message.channel.send("Fetching Information..");
			// goes to page
			const browser = await puppeteer.launch();
			const page = await browser.newPage();

			await page.goto(url);

			// grabs overall element
			const [overallEl] = await page.$x(
				"/html/body/div[3]/div[2]/div[1]/div/div[4]/div/span"
			);
			// grabs overall text
			const overall = await (
				await overallEl.getProperty("textContent")
			).jsonValue();

			// grabs deaths element
			const [deathsEl] = await page.$x(
				"/html/body/div[3]/div[2]/div[1]/div/div[6]/div/span"
			);

			// grabs death text
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
		scrapeCount(message, "https://www.worldometers.info/coronavirus/");
	},
};
