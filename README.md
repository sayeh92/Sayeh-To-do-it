# Sayeh To do it

Instructions

Create a Core Console project a. Push empty project to GitHub.

Create a new folder called Models

Create Person class in folder Models. a. Required private fields: i. Id (int and readonly) ii. firstName (String). iii. lastName (String). b. Make a constructor that can build the object (at least one that takes in an int for id field). c. Use Properties to: i. Read names of the person. ii. Prevent firstName/lastName from saving NULL & Empty. iii. Read what id a person has. d. Unit test Person class. e. Commit changes.

Create Todo class in the model folder a. Required private fields: i. are id (int and readonly) ii. description (String) iii. done (bool) iv. assignee (Person). b. Make a constructor that take in id (int) and a description (String). c. Create appropriate Properties to get/set the fields. d. Unit test Todo class. e. Commit changes.

Create a new folder called Data.

Create a new class PersonSequencer in Data folder. a. In PersonSequencer creates a private static int variable called personId. b. Add a public static method called NextPersonId that increment and return the next personId value. c. Add a public static method called Reset() that sets the personId variable to 0. d. No Properties. e. Unit test PersonSequencer. f. Commit changes.

Create a new class TodoSequencer in Data folder that have the same behaviour as PersonSequencer but just different names to suit ToDo instead of Person. a. Unit test TodoSequencer.

Create a new class called PeopleService inside the Data folder. a. Have a private static Person array declared and instantiated as empty and not null (new Person[0]). b. Add a method public int Size() that return the length of the array. c. Add a method public Person[] FindAll() that return the Person array. d. Add a method public Person FindById(int personId) that return the person that has a matching personId as the passed in parameter. e. Add a method that creates a new Person, adds the newly created object in the array and then return the created object. You have to “expand” the Person array. (tip: send in parameters needed to create the Person object and use the PersonSequencer to give a unique personId) f. Add a method public void Clear() that clears all Person objects from the Person array. g. Unit test People class. h. Commit changes.

Create a new class called TodoService inside the Data folder. a. TodoItems should have the same functionality as the PeopleService class. b. Unit test TodoItems class c. Commit changes.

Add the following methods to TodoService class a. public Todo[] FindByDoneStatus(bool doneStatus) – Returns array with objects that has a matching done status. b. public Todo[] FindByAssignee(int personId) – Returns array with ToDo´s that has an assignee with a matching id. c. public Todo[] FindByAssignee(Person assignee) – Returns array with ToDo´s that has this Person as its assignee. d. public Todo[] FindUnassignedTodoItems() – Returns an array of ToDo´s that does not have an assignee set to it. e. Unit test changes f. Commit.

Add the following to TodoService AND PeopleService class. a. Method to remove object from array. (not nulling) i. You need to find the correct array index of the object. ii. You need to rebuild/resize array by excluding the object on found index. b. Unit test changes c. Commit and Push to GitHu b. Commit changes.
