DECLARE @json NVARCHAR(MAX)

SET @json='[
    {
	"id": 1,
	"personid": 1,
      "positiontitle": "Software Developer Intern",
      "company": "Homecare Software Solutions, Frisco TX",
      "timeperiod": "May 2021 - Dec 2021",
      "bullet1": "• Monitored server events, KAFKA processing lags and fixed/reprocessed issues in SQL server database to maintain server health.",
      "bullet2": ""
    },
    {
	"id": 2,
	"personid": 1,
      "positiontitle": "Computer Science Grader",
      "company": "The University of Texas at Dallas",
      "timeperiod": "Feb 2021 – May 2021",
      "bullet1": "• Analyzed and graded programming projects in Data Structures and Algorithms.",
      "bullet2": ""
    },
    {
	"id": 3,
	"personid": 1,
      "positiontitle": "Mobile Developer Intern",
      "company": "Automatic Infotech, Pune",
      "timeperiod": "June 2019 – July 2019",
      "bullet1": "• Designed and developed cross-platform mobile applications for Employee Self Service and Ticket Management System.",
      "bullet2": "• Used Scrum software process to evolve basic application and include features as required."
    }
  ]';

insert into dbo.Experience(positiontitle,  
              company,  
              timeperiod,  
              bullet1,
			  bullet2,
			  userid)
SELECT * FROM  
 OPENJSON ( @json )  
WITH (   
              positiontitle   nvarchar(50) '$.positiontitle' ,  
              company     nvarchar(50)     '$.company',  
              timeperiod nvarchar(50) '$.timeperiod',  
              bullet1 nvarchar(50)          '$.bullet1' ,
			  bullet2 nvarchar(50) '$.bullet2',
			  userid int '$.personid'
 ) 