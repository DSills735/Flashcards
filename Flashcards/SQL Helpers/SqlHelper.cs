using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcards.SQL_Helpers
{
    internal class SqlHelper
    {
        internal static string CreateStackTable()
        {
            return @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Stacks')
                    BEGIN
                         CREATE TABLE Stacks (
                            StackID INT PRIMARY KEY IDENTITY(1,1),
                            Subject VARCHAR(255)
                             );
                    END";

        }
        internal static string CreateFlashcardTable()
        {
            return @"IF NOT EXISTS ( Select * FROM sys.tables WHERE name = 'Flashcards')
                    BEGIN

                        CREATE TABLE Flashcards (
                            FlashcardID INT PRIMARY KEY IDENTITY(1,1),
                            Question VARCHAR(255),
                            Answer VARCHAR (255),
                            StackID INT,
                            FOREIGN KEY (StackID) REFERENCES Stacks(StackID)
                            ON DELETE CASCADE   
                            );
                    END";
        }
        internal static string CreateHistoryTable()
        {
            return @"IF NOT EXISTS (Select * FROM sys.tables WHERE name = 'History')
                        BEGIN
                               CREATE TABLE History (
                                    HistoryID INT PRIMARY KEY IDENTITY(1,1),
                                    Date VARCHAR(255),
                                    Score VARCHAR(255)
                                );
                        END
                                    ";
        }
    }
}
