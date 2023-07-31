namespace Example
{
    public static class Proc
    {
        public static void Init(string name, string command)
        {
            using (var process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = name,
                    Arguments = $"/C {command} && exit",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                process.Start();
                process.WaitForExit();
            }
        }
    }
}
