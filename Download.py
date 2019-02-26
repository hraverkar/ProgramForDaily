import requests 
from bs4 import BeautifulSoup 

archive_url = "http://dl2.funsaber.net/serial/Friends/season%202/720/"

def get_video_links(): 
	
	# create response object 
	r = requests.get(archive_url) 
	
	# create beautiful-soup object 
	soup = BeautifulSoup(r.content,'html5lib') 
	
	# find all links on web-page 
	links = soup.findAll('a') 

	# filter the link sending with .mp4 
	video_links = [archive_url + link['href'] for link in links if link['href'].endswith('.mkv')] 

	return video_links 


def download_video_series(video_links): 

	for link in video_links: 

		'''iterate through all links in video_links 
		and download them one by one'''
		
		# obtain filename by splitting url and getting 
		# last string 
		file_name = link.split('/')[-1] 

		print ("Downloading file:%s"%file_name );
		
		# create response object 
		r = requests.get(link, stream = True) 
		
		# download started 
		with open(file_name, 'wb') as f: 
			for chunk in r.iter_content(chunk_size = 1024*1024): 
				if chunk: 
					f.write(chunk) 
		
		print ("%s downloaded!\n"%file_name );

	print ("All videos downloaded!");
	return


if __name__ == "__main__": 

	# getting all video links 
	video_links = get_video_links() 

	# download all videos 
	download_video_series(video_links) 
