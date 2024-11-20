import requests
import time
from bs4 import BeautifulSoup
from csv import writer
import sys

search = sys.argv[1]
location = sys.argv[2]
pageToSearch = sys.argv[3]
from bs4 import BeautifulSoup
import csv

class Search():
    
    def __init__(self, search, location, pageToSearch):
        self.search = search
        self.location = location
        self.pageToSearch = pageToSearch
        self.page = 0
    def searching(self):
        with open(f'{self.search}-jobs.csv', 'w') as csv_file:
            csv_writer = writer(csv_file)
            headers = ['Title', 'Company', 'Location', 'Description', 'Salary', 'Link']
            csv_writer.writerow(headers)
            pages = 0

            for i in range(1, self.pageToSearch):

                url = f'https://www.indeed.co.uk/jobs?q={self.search}&l={self.location}&radius=5&start={self.page}'
                urlHeaders = {"User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.142 Safari/537.36"}
                page = requests.get(url, headers=urlHeaders)
                soup = BeautifulSoup(page.content, 'html.parser')

                posts = soup.find_all(class_='jobsearch-SerpJobCard unifiedRow row result clickcard')

                titles_ = soup.find_all(class_='title') 
                company_ = soup.find_all(class_='company')
                location_ = soup.find_all(class_='location')
                info_ = soup.find_all(class_='summary')
                salary_ = soup.find_all(class_='salary no-wrap')

                for i in range(len(titles_)):
                    try:
                        titl = titles_[i].get_text().replace('\n', '')
                        link = 'https://www.indeed.co.uk' + titles_[i].find('a')['href'].replace('\n', '')
                        comp = company_[i].get_text().replace('\n', '')
                        loc = location_[i].get_text().replace('\n', '')
                        inf = info_[i].get_text().replace('\n', '')
                        sal = salary_[i].get_text().replace('\n', '')
                        csv_writer.writerow([titl, comp, loc, inf, sal, link])
                        
                        
                    except Exception as ex:
                        csv_writer.writerow([titl, comp, loc, inf, '', link])
                        
                        
                        

                        

                pages+=1
                self.page+= 10
                print(f'Page: {pages}')


        

            


        

                

            

searched = Search(search, location, pageToSearch)
searched.searching()
