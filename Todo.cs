using System;
using System.Threading.Channels;

namespace demo_oop_todo;

public class Todo
{
	public int TodoId {get; set;}
	public string Name {get; set;}
	// Ändrade Done setter till private för att illustrera. Se Program.cs
	public bool Done { get; private set;}
	
	public Todo(int id, string name) 
	{
		this.TodoId = id;
		this.Name = name;
		this.Done = false;
	}
	
	public void MarkAsDone() 
	{
		this.Done = true;
	}
	
}
