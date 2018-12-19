# AltenVehicle
> Alten Vehicle Monitor.

# SOLUTION DESIGN AND ANALYSIS
The solution has been designed with .Net Core 2.1 and Visual Studio 2017

# HOW TO RUN THE SOLUTION

The Main Project is AltenVehiclesMonitor has one view page which displays all vehicles data and update their status every minute
Just Run this project and it will open and displays the main dashboard for the vehicles data and status

You can filter by the vehicles either by customer or by vehicles status from the dropdown filters in the main page

# CONTINUOUS INTEGRATION

I have used TeamCity for CI and testing the project

# CLOUD PLATFORM USED

i have used AWS as cloud platform for hosting the Web App and for the microservices
Main Web App: 
http://altenvehiclesmonitor-dev.us-east-1.elasticbeanstalk.com

Vehicle Status Service:
http://vehiclestatus-dev.us-east-1.elasticbeanstalk.com/api/VehiclesStatus/2

Customer Vehicles Service:
http://customervehicles-dev.us-east-1.elasticbeanstalk.com/api/customervehicles/2

Vehicles Microservice:
http://vehiclesmicroservices-dev.us-east-1.elasticbeanstalk.com/api/vehicles

# SERVERLESS ARCHITECTURE

I believe that it is possible for this application to be in Serverless architecture by migrating all its services into FaaS like AWS Lambda Function or MS Azure Functions,
and by doing this we will decrease the cost as we only will pay by function calls.