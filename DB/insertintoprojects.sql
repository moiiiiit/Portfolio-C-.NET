DECLARE @json NVARCHAR(MAX)

SET @json='[
    {
	"personid" : 1,
	"projectid" : 1,
      "title": "Sensory Cuff",
      "medialink": "Sensory Devices.mp4",
      "mediaorientation": "portrait",
      "projecturl": "https://sites.utdallas.edu/epics-autism-center/updates/",
      "description": "A mobile application built to control a remotely inflatable pressure cuff I made with Arduino to calm autistic students experiencing a sensory overload. The prototype is being tested, and teams are still working to build this. "
    },
    {
	"personid" : 1,
	"projectid" : 2,
      "title": "This Portfolio Website!",
      "projecturl": "https://github.com/moiiiiit/angular-portfolio",
      "description": "Hosted on firebase and written in Angular, this website is open source for you to use and make a portfolio for yourself! You do not need any programming experience. Good luck!"
    },
    {
	"personid" : 1,
	"projectid" : 3,
      "title": "Medila",
      "projecturl": "https://github.com/anoopsonar30/Medila",
      "medialink": "2.mp4",
      "mediaorientation": "portrait",
      "description": "A virtual patient consultation application frontend to help doctors look after patients from home during the coronavirus pandemic."
    },
    {
	"personid" : 1,
	"projectid" : 4,
      "title": "SupplyShare",
      "projecturl": "https://github.com/moiiiiit/supply-sharing-app",
      "medialink": "3.mp4",
      "mediaorientation": "portrait",
      "description": "An ecommerce mobile application that allows users to buy items from bulk stores and split them later by getting a driver to deliver the items to them."
    },
    {
	"personid" : 1,
	"projectid" : 5,
      "title": "FitnessApp",
      "projecturl": "https://github.com/moiiiiit/fitnessApp",
      "medialink": "4.mp4",
      "mediaorientation": "portrait",
      "description": "A quick flutter-built fitness tracker app I built to demonstrate my skills to a potential employer in Pune, India."
    },
    {
	"personid" : 1,
	"projectid" : 6,
      "title": "My ReactJS Portfolio",
      "imglink": "React-Portfolio.png",
      "mediaorientation": "landscape",
      "projecturl": "https://mohitbhole.com/alt-portfolio",
      "description": "A little more quirky than this portfolio."
    },
    {
	"personid" : 1,
	"projectid" : 7,
      "title": "Machine Learning Control of Transistor Load-Pull Simulation",
      "company": "For Qorvo - as part of UTD CS Capstone",
      "description": "An automation to simulate radio frequency circuits with different parameters and generate Smith chart using a ML model with 99.8% accuracy."
    },
    {
	"personid" : 1,
	"projectid" : 8,
      "title": "Walk Me Amadeus",
      "projecturl": "https://github.com/jaymspeights/HackUTA18",
      "company": "HackUTA WINNER Best use of HERE-API",
      "description": "Developed a Crowd sourced web-based non-roadway based navigation app using heat-based algorithms. Useful for campuses and hiking trails."
    },
    {
	"personid" : 1,
	"projectid" : 9,
      "title": "NEAT Webserver API",
      "projecturl": "https://github.com/moiiiiit/NEATWebserver",
      "description": "Developed a Python based server-side code to run an API to train a neural network on multiple computers simultaneously."
    }
  ]';
  insert into dbo.Project(projecttitle,  
              medialink,  
              mediaorientation,  
              projecturl,
			  description,
			  userid,
			  imglink)

SELECT * FROM  
 OPENJSON ( @json )  
WITH (   
              projecttitle nvarchar(50) '$.title',  
              medialink nvarchar(50) ,  
              mediaorientation nvarchar(50) ,  
              projecturl nvarchar(50) ,
			  description nvarchar(50) ,
			  userid int '$.personid',
			  imglink nvarchar(50)
 ) 