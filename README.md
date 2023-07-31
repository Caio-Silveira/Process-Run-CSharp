# Usage Instructions - Process Run CSharp

This repository contains a C# code example that demonstrates how to run external processes using the `Proc` class. The `Proc` class provides a convenient way to execute commands in a new process.

## How to Use the Code

1. Clone or download this repository to your computer.

2. Open the solution in Visual Studio or another C# development environment.

3. The code includes a class named `Proc` inside the `Example` namespace.

4. The `Proc` class contains a static method named `Init`. This method takes two parameters: `name` (the name of the executable or script to run) and `command` (the command to execute).

5. Inside the `Init` method, a new `Process` object is created and configured with the provided `name` and `command`.

6. The process is started using the `Start` method, and it will execute the specified command.

7. The `CreateNoWindow` property is set to true to prevent the command prompt window from being displayed.

8. The `UseShellExecute` property is set to false to enable the execution of commands directly, without the use of the Windows shell.

9. The process will wait for the command to complete using `WaitForExit`, and then it will terminate.

10. To use the `Proc` class in your project, call the `Init` method and provide the desired `name` and `command` as arguments.

## Example Code

[Example Code here](https://raw.githubusercontent.com/Caio-Silveira/Process-Run-CSharp/main/Proc.cs)

## Important Note

• Be cautious when running external processes, as they may have security implications. Ensure that you trust the commands and arguments provided to the Proc class to prevent potential security risks.

## Credits

This code example was created by [Caio Silveira](https://github.com/Caio-Silveira).

Feel free to use and modify the code in your own projects. If you encounter any issues or have suggestions for improvements, do not hesitate to open an issue or submit a pull request.

Happy coding! 😊


