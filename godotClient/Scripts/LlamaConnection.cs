using Godot;
using godotllama2.LLamaClient;
using System;
using System.Threading.Tasks;


public partial class LlamaConnection : Node
{
	[Export]
	public string serverAddress = "ws://localhost:8765";

	public override void _Ready()
	{
		ClientLlama llamaConnection = new(serverAddress);
		
		Task<string> task = Task.Run(async () => {
			await llamaConnection.Start();
			return await llamaConnection.SendMessageToServer("Paris is the capital of");
		});
		string result = task.Result;
		GD.Print(result);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
