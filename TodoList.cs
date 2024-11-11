using System;

namespace demo_oop_todo;

public class TodoList
{
	public string Name {get; set;}
	public List<Todo> List = new List<Todo>();
	
	public TodoList(string name) 
	{
		this.Name = name;
	}
	
	public void AddNewTodo(string name) 
	{
		int newId = List.Count + 1;
		Todo newTodo = new Todo(newId, name);
		List.Add(newTodo);
	}
	
	public void ShowAllTodos() 
	{
		System.Console.WriteLine("Här är alla uppgifter:");
		foreach (Todo todo in List.Where(todo => !todo.Done)) 
		{
			// if( kolla om Todo är done eller inte) 
			System.Console.WriteLine("(" + todo.TodoId + ") - " + todo.Name);
		}
	}
	
	public void RemoveTodo(int id) 
	{
		Todo findTodo = List.Find(t => t.TodoId == id);
		
		if (findTodo != null) 
		{
			findTodo.MarkAsDone();
			System.Console.WriteLine("Uppgiften klar!");
		} else 
		{
			System.Console.WriteLine("Ogiltigt ID!");
		}
	}
}
