using UnityEngine;
using UnityEngine.Events;
using System.Diagnostics;

public class AbstractAppleScript
{
	private static AbstractAppleScript _script ;

	public static AbstractAppleScript script {
		get {

			if (_script == null)
				_script = new AbstractAppleScript ();

			return _script;
		}
	}

	public virtual string Execute (string command)
	{
		var process = new Process {
			StartInfo = new ProcessStartInfo {
				FileName ="osascript",
				Arguments = string.Format ("-e '{0}'", command),
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true,
			}
		};

		process.Start ();

		while (!process.StandardOutput.EndOfStream) {
			string line = process.StandardOutput.ReadLine ();
			if (!string.IsNullOrEmpty (line))
				return line;
		}

		return string.Empty;
	}

	public virtual void ExecuteFromFile (string filePath)
	{
		throw new System.NotImplementedException ();
	}
}
