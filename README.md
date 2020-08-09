# CustomerOrderViewer
## This project represents a knowlegde and experience of working with SQL Server, commands and etc.
In this project we have a Model folder with CustomerOrderDetailModel class and Respository folder with CustomerOrderDetailCommand class inside.
Model helps us get the data from db and put all the records in properties of class (object)
CustomerOrderDetailCommand class initializes an object to get the data from db. I used there three other classes to work with db: SqlConnection, SqlCommand and SqlDataReader.
SqlConnection - make a connection to db.
SqlCommand - write a command which will be executed
SqlDataReader - gets all the data inside itself
and after SqlDataReader has got the data, we separate it in model object and add this object to a List.


# The main goal of this project is to show the way you get connected with a local db, execute a command and parse the data in List-object to work with in future.
I had created a local db and added the Tables with data. Then wrote a command to create a view with only data, which need to work my project with.

Now I don't know how to push the local db in GitHub repository, and don't want to waste time for searching it because of working on the next chapter of this project.
One day I will ad my local db there and everythink will work well. Now you can just look at code :) unfortunately.
