# Flashcards 
This app is a Console app that will allow users to create and manage stacks of flashcards. Flashcards are managed through a stacks and flashcards table linked via foreign key. In this app you can add, delete, and quiz yourself on flashcards. You can also see your history for each stack. 

**Tech used:** C#, MSSQL, SQL Server Managment, VS 2026, Spectre, Dapper

I used C# along with Dapper and Spectre to design the application. SQL, Dapper ORM, MSSQL and SQL Server management was used to manage the database. I really enjoyed using Spectre more and learning more about how to create a vibrant and pleasant user interface with it!

## Optimizations

I would like to enhance the user experience and allow a more seamless use of the interface, being able to add/delete/change cards from the study session would be great. I also would like to streamline the areas where cards are created, as the process seems very convoluted to me as it sits now. I would also like to streamline the SQL management, as the single class for that quickly got out of hand. 


## Lessons Learned:

I learned a ton throughout this process. This was my first real introduction to object mapping, and DTOs. Those felt overly complicated when I started, but quickly became something that felt easy, and very intuitive. 
I also expanced on my SQL usage from my previous project (Coding Tracker, found here: https://github.com/DSills735/CodingTracker). In that project I did a similar thing with my SQL storing them all in one class. 
It worked well on that project with a limited number of queries, but on this project it started to get really confusing. I would like to organize this better in the future, maybe create a class per type of query, or create a SQL class within each namespace. I really thoroughly enjoyed the challenges intorduced to me on this project!

## Project Requirements


 - You'll need two different tables for stacks and flashcards. The tables should be linked by a foreign key.

 - Stacks should have an unique name.

 - Every flashcard needs to be part of a stack. If a stack is deleted, the same should happen with the flashcard.

 - You should use DTOs to show the flashcards to the user without the Id of the stack it belongs to.

 - When showing a stack to the user, the flashcard Ids should always start with 1 without gaps between them. If you have 10 cards and number 5 is deleted, the table should show Ids from 1 to 9.

 - After creating the flashcards functionalities, create a "Study Session" area, where the users will study the stacks. All study sessions should be stored, with date and score.

 - The study and stack tables should be linked. If a stack is deleted, it's study sessions should be deleted.

 - The project should contain a call to the study table so the users can see all their study sessions. This table receives insert calls upon each study session, but there shouldn't be update and delete calls to it.


