2024-01-17
1836
Review : Part 1 ,2 ,and 3 (Get Started, Add a Controller, and Add a View)

MVC Overview:

MVC is a design pattern commonly used in software development for organizing code in a way that
separates concerns and promotes modularity. It consists of three main components:

Model:  Represents the application's data and business logic. It is responsible for managing 
		the data and notifying observers (usually views) about any changes.

View:   Represents the user interface and is responsible for presenting the data to the user. 
		It receives input from the user and communicates changes back to the model.

Controller: Acts as an intermediary between the model and the view. It receives user input from 
			the view, processes it (possibly modifying the model), and updates the view accordingly.



Outputs:

part-1: url= https://localhost:7209/
		Out= Welcome

Part-2: Add a controller
	A)	url= https://localhost:7209/HelloWorld  
		Out= This is My Movie List
			 Hello from our View Template!
		
	B)  url= https://localhost:7209/HelloWorld/welcome 
		Out= Welcome
			 Hello

Part-3: Part 3, add a view to an ASP.NET Core MVC app
		url= https://localhost:7209/HelloWorld/welcome?name=kejan&id=5
		Out= Welcome
				Hello kejan
				Hello kejan
				Hello kejan
				Hello kejan
				Hello kejan



OverView: This is a very basic overview, and actual implementations may vary depending on the programming 
		  language and framework you're using. The key idea is to separate concerns, making your code more 
		  modular and maintainable.



2024-01-18
1331
Review : 4th Part (Add a Model)

Model: Represents the application's data and business logic. It is responsible for data storage, retrieval, and manipulation.
:- Adding a model to an ASP.NET Core MVC app involves defining data structures that represent the application's business entities. 
:- These models are typically used to interact with a database, process user input, and facilitate communication between different 
 components of the MVC architecture.


 The DataType attribute on ReleaseDate specifies the type of the data (Date). With this attribute:
	-> The user isn't required to enter time information in the date field. 
	-> Only the date is displayed, not time information.

Output:->

Index
Create New

Title	ReleaseDate	Genre	Price	
kejan	31-12-2001	movies app	20000.00	Edit | Details | Delete
jada	31-12-2001	app movie	50000.00	Edit | Details | Delete



2024-01-25
1833
Review : 5th Part (work with a database)
20240125161933_InitialCreate <--: Initial File.

:-> Working with a database involves interacting with a structured collection of data to store, retrieve, update, and manage 
	information efficiently. Databases are essential for organizing and accessing large volumes of data in a systematic way.
:-> Database Management System (DBMS): A DBMS is software that facilitates the creation, maintenance, and manipulation of databases. 
:-> Popular examples include MySQL, PostgreSQL, Oracle, and Microsoft SQL Server.

:-> When you "seed" the database, it means populating it with initial data so that the application starts with some predefined records. 
:-> This can be beneficial for testing, demonstrating functionality, or simply providing default values.


Output:->


			Create
Movie

Title:  Deadpool
Date :  yyyy-mm-dd
Genre:	Action
Price:	100.00

Create
Back to List





2024-01-27
1017
Review : 6th Part (controller methods and views)

:-> Controllers handle the logic of your application, including processing input, interacting with the model (database), and rendering views. 
:-> Views are the presentation layer of your application, typically containing HTML, CSS, and sometimes JavaScript to display data to users.

:-> Controller Actions: 
	Controller actions are methods within the controller component of an MVC framework. They handle incoming
	requests from users, process data, interact with the model (database), and determine which view to render. 
:-> Controller actions encapsulate the logic of your application and serve as the bridge between the user interface and the data layer.

:-> Views: 
	Views are responsible for presenting data to the user in a format they can understand, typically HTML with embedded 
	dynamic content.
:-> Views are separate from the controller and model, ensuring a clear separation of concerns. They receive data from the controller and use 
	templates or layouts to generate the final HTML output that is sent to the user's browser.




2024-01-30
2045
Review : 7th and 8th Part (Add a Search and A new File)

Model:

:-> Add search: 
		Implementing search functionality allows users to find specific information within your application. 
:-> This typically involves creating a search form where users can input keywords or filters, then processing that input on the 
	backend to retrieve relevant data from the database. The search results are then displayed to the user, often in a list or grid format.

:-> Add a new field: 
		Adding a new field involves modifying your database schema to include a new column or attribute that stores additional
	data related to your application's domain. After updating the database schema, you'll also need to update your application's codebase to
	handle the new field, including modifying any forms, database queries, and views that interact with that data. 
:-> This could be anything from adding a new "description" field to a product table to adding a "birthdate" field to a user profile.



2024-01-31
2105
Review : 9th and 10th Part (Add validation and Examine Details and Delete )

Model: 

:-> Adding validation: 
		ensures that the data entered by users meets certain criteria or constraints before it is saved to the database. 
:-> This can include checking for required fields, validating the format of input (such as email addresses or phone numbers), ensuring 
	data falls within certain ranges (like dates or numerical values), and preventing malicious input (such as SQL injection). 
:-> Validation helps maintain data integrity and prevents errors or incorrect data from being stored in the database.

:-> Examine Details and Delete: 
		functionality allows users to view detailed information about a specific record or entity in your application, 
	typically through a dedicated "details" page. This page displays all relevant information about the record and may include additional 
	actions or options related to that record. Users can also delete records if necessary, typically by clicking a "delete" button or link. 
:-> Deleting a record permanently removes it from the database, so it's important to implement confirmation dialogs or other safeguards to prevent 
	accidental deletion.



Outputs:


										Index
Create New


All:   Title:                [Filter]

Title					Release Date	Genre	Price			Rating	
Breaking Bad			2023-03-13		Comedy	₹ 100.00		10			Edit | Details | Delete
Avengers: Age of Ultron	2012-02-23		Comedy	₹ 99.99			8.6			Edit | Details | Delete
Rio Bravo				2015-04-15		Western	₹ 30.90			6.6			Edit | Details | Delete
Deadpool				2021-10-01		Action	₹ 100.00		5.7			Edit | Details | Delete
