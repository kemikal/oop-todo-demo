// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using demo_oop_todo;

Console.WriteLine("Hello, World!");

bool run = true;
TodoList todoList = new TodoList("Skapa en Todo app");

// Exempel på hur vi nu av misstag inte skulle kunna ändra done på ett objekt i lisan av misstag.
// Kommentera fram dessa rader så ser ni skillnad på hur vi kan ändra Name men inte Done via de vanliga getters and setters.
// todoList.AddNewTodo("test");
// todoList.ShowAllTodos();
// todoList.List[1].Name = "ändrar";
// todoList.List[1].Done = true;

while (run) 
{
	System.Console.WriteLine("Vad vill du göra?");
	System.Console.WriteLine("A. Lägg till en uppgift.");
	System.Console.WriteLine("B. Ta bort en uppgift.");
	System.Console.WriteLine("C. Visa alla uppgifter.");
	System.Console.WriteLine("X. Avsluta programmet.");
	
	string choice = Console.ReadLine();
	
	Console.Clear();
	
	switch (choice) 
	{
		case "a":
		System.Console.WriteLine("Vad vill du lägga till för uppgift?");
		string input = Console.ReadLine();
		todoList.AddNewTodo(input);
		break;
		
		case "b":
		System.Console.WriteLine("Vilken uppgift vill du ta bort?");
		todoList.ShowAllTodos();
		
		if (int.TryParse(Console.ReadLine(), out int id)) 
		{
			todoList.RemoveTodo(id);
		} else 
		{
			System.Console.WriteLine("Ogiltig input!");
		}
		
		break;
		
		case "c":
		System.Console.WriteLine("Här är alla uppgifter:");
		todoList.ShowAllTodos();
		break;
		
		case "x":
		System.Console.WriteLine("Avsluta");
		run = false;
		break;
		
		default:
		System.Console.WriteLine("Inget sånt menyval");
		break;
	}
}