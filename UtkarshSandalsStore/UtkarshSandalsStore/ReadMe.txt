Assignment 1 - Develop Web App in ASP.NET 22 Winter

Project Name: Assignment 1
Project Purpose: Modify the Tutorial provided by Microsoft according to my assigned product for my assignment 1 (ie. Sandals) in order to create something new from it.
Project Author: Utkarsh Patel
Project Date Created: 2022-02-22 to 2022-02-25
Student Number: 0785541




2022-02-22
.......Getting Started.......

1000 - started working on my Assignment 1, my assigned topic for the Assignment 1 is Sandals.

1012 - created a Web App using the tutorial by selecting the ASP.NET Core Web app (Model-View-Controller) in Visual Studio 2019 with using c# code in all files.

1015 - Navigate to each folder and try to understand what it is...trying to understand why that particular code is present in the files.

1030 - After understanding and confirm that each file is present in my Project, I tried to run the app and try to see if there will an error or not.

1035 - yes, it's I got my desired output which I actually run the app and everything seems to be correct as of now..... :) I'm Happy.......

1040 - Tried to edit the Welcome message in the app's home screen and replace the Welcome word with "Welcome to the Utkarsh Sandals Store!" in h3 tag and commenting out the link which is located below the message called Welcome in order to modify according to my needs.

1050 - Tried to run the app and hope it will displays as my expection....

1100 - yes it will shows an message correctly :) hurray I made it, after that I modified the message for the privacy page as well as change the description in the paragraph tag in it..

1105 - I tried to customized the default messages according the product assigned to me...

1110 - next I added a new page called AboutUs to my home page by creating the razor page called - AboutUs.cshtml in the home folder of Views.

1120 - after that I included the link to my homepage using the nav tag in the file called - _Layout.cshtml

1130 - and finally add a code to return a view of the file called AboutUs.cshtml file...if user clicked on the link called About Us from the home page.

1135 - finally I tried to run the app and hope it runs as of my expectations......

1136 - Hurray it works fine till now :)

.......Getting Started.......


2022-02-23
.......Add a controller.......

8000 - Added a new controller in the Controller folder and called it : HelloWorldController.cs.

8005 - after that I tried to replace the particular keyword or word accordingly so that it inclined to or cnnects to my project called UtkarshSandasStore....

8010 - Particularly modified namespace keyword and much more...

8015 - Add a code to the file called HelloWorldController.cs so that it returns a view of my page called AboutUs, when I click the link called AboutUs.

8020 - Finally tried to run the application and hope it will shows the page of my AboutUs when I click the link.

8030 - Hurray......I got it :)

.......Add a controller.......




.......Add a View.......

8035 - Now I modified the index method in the HelloWorldController class in the Controller folder.

8040 - Modified the code so that the code will return the view of the page...when the method called...

8050 - Added a new folder to my views folder and called it as HelloWorld and insidet that folder creafteda a file called Index.cshtml (ie. Razor view - Empty page)

9000 - Added a code in the file and display a message so that it distinguised it's a razor page view from ur template.

9010 - I tried to run the app....and I got my desired output :)

9020 - Modified the whole layout according to my need for my Assignment 1... includes mofification to my title, navlist items names, and footer of the project in the _Layout.cshtml file in the Shared subfolder of the views.

9030 - Tried to run the app and hope it will replace the keyword which I recently modified to my project.

9035 - yes....I got it :)

.......Add a View.......



2022-02-24

.......Add a Model.......

7000 - now I added a new Data Model Class called Sandal.cs in the Models Folder.

7010 - After that I modified a template which was default created, so that I add my properties of my product called Sandals, which Includes...ArtNumber, CompanyName, Colour, Material, Size, Price, and Ratings

7030 - Sucessfully added my properties to it.

7035 - After that I added some reuired Nuget Packages to my Project in order to execute my files using commands in PM Package Manager console.

7045 - After that I added a new scaffolded item using MVC Controller with Views, Using Entity Frmework....

7050 - in the new tab I select my Model Class, Data Context Class and added a Controller Name and finnaly add it.

7055 - Then I run the commands of the Initial Migraction in the PM Console.... called Add-Migration InitialCreate and Update-Database

8005 - finnly it's time to Test the app .....Omg I hope it will work and don't throw an error to me.....

8010 - Hurray .................I Complete this step :)

8020 - Added some data in the DB and it's work fine :)

.......Add a Model.......


.......Work with Database.......

8030 - in the view tab of the Visual Studio 2019 open for SQL Server Object Explorer open my db to check the data wich i manually feed up was there or not...

8035 - Yes it all there and works fine :)

8040 - after that I cleared all my data in the app which I manually feed up in it.

8050 - I created a new class Called SeedData in the Models Folder and modified the default template according to my project and feeds the data in it.

9020 - add a seed initializer in the program.cs file of my project

9030 - I tried to test the app and check it show my data or not.....

9035 - Hurray it's shows all my data and works fine :)

.......Work with Database.......


.......Controller actions and views.......

9040 - in this part I added code in my Sandal.cs in order to display the property name which contain two words, correctly and set the constraints or range to the price property

9045 - Finally treid to run the app and check that all works fine.....

9050 - It works as my expectation... :)

.......Controller actions and views.......




.......add search.......

1000 - In this part I add a modified the index method of the SandalsController.cs file according to the search functionality I need in my assignment.

1030 - I tried to run the app and filter it with the company name through the url.

1040 - Sucessfully filter the data based on the company name I had Provided in the url with query string.

1045 - now I add a form tag so that I don't required to put the company name in the url if I want to filter the data.

1055 - after that I run the app and hope it will run

1105 - it runs fine and the data also filtered based on the company name I had provided.

1110 - after that I also add another search functionality based on the colour property so I add a class called SandalColourViewModel.cs in the Models folder.

1120 - and modified the Index method in the SandalsController class and also update the Index.cshtml file in the Sandals folder of Views.

1140 - finally tried to run the app

1145 - Check it works properly as my expectations and yes it works fine :)

.......add search.......



.......add validation.......

1150 - in this part I modified the Sandal.cs file code so that I ristrict user to put somthing which I didn't want to save based on the property definition and datatype.

1200 - Tried to run the app....

1205 - Hurray my validation works fine :)

.......add validation.......


1215 - Finally add css to my project as well as some product Images in the Project in order to customized the project accordind to my assignned product.


1240 - I uploaded my project to the Azure and below I had Provided the link to my project

Azure Link: 

I completed my Project and it look as fine and everything works perfectly.


