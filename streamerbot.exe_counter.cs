using System;
using System.IO;
using System.Threading;

public class CPHInline
{
	public bool Execute()
	{
            // Increment var_name by 1 and pecific long variable to test
            long var_name = CPH.GetGlobalVar<long>("var_name", true);
            
            var_name = var_name + 1;
            
            CPH.SetGlobalVar("var_name", var_name, true);
            
            long numberToTest = var_name;
            
			//Special action if dividable by a given number (25 here)
            if (numberToTest % 25 == 0)
            {
				// Specify the path to the HTML file
				string filePath = @"HTML file location";
				
				// Specify the name of the CSS file in the same directory
				string cssFileName = "styles.css";
				
				// Create the new HTML content that references the CSS file
				string newText = $@"
				<!DOCTYPE html>
				<html lang='en'>
				<head>
					<meta charset='UTF-8'>
					<meta name='viewport' content='width=device-width, initial-scale=1.0'>
					<title>var_nameCounter</title>
					<link rel='stylesheet' href='styles.css'>
					<link rel='preconnect' href='https://fonts.googleapis.com'>
					<link rel='preconnect' href='https://fonts.gstatic.com' crossorigin>
					<link href='https://fonts.googleapis.com/css2?family=New+Rocker&display=swap' rel='stylesheet'>
				</head>
				<body>
					<p class='adjustable-sentence'>name: {var_name}</p>
				</body>
				</html>";

				// Write the new text to the file, overwriting any existing content
				File.WriteAllText(filePath, newText);
				
				Thread.Sleep(10000);
				
				//The ObsGetConnectionByName is most times OBS-Socket if this is different in your case change it to the name given in your OBS
				CPH.ObsSetSourceVisibility("scene", "source", true, CPH.ObsGetConnectionByName("OBS-Socket"));
				
				//Timer till the source gets invisible again
				Thread.Sleep(15000);
				
				CPH.ObsSetSourceVisibility("scene", "source", false, CPH.ObsGetConnectionByName("OBS-Socket"));
				
                return true;
            }
            else
            {
				// Specify the path to the HTML file
				string filePath = @"HTML file location";
				
				// Specify the name of the CSS file in the same directory
				string cssFileName = "styles.css";
				
				// Create the new HTML content that references the CSS file
				string newText = $@"
				<!DOCTYPE html>
				<html lang='en'>
				<head>
					<meta charset='UTF-8'>
					<meta name='viewport' content='width=device-width, initial-scale=1.0'>
					<title>var_nameCounter</title>
					<link rel='stylesheet' href='styles.css'>
					<link rel='preconnect' href='https://fonts.googleapis.com'>
					<link rel='preconnect' href='https://fonts.gstatic.com' crossorigin>
					<link href='https://fonts.googleapis.com/css2?family=New+Rocker&display=swap' rel='stylesheet'>
				</head>
				<body>
					<p class='adjustable-sentence'>name: {var_name}</p>
				</body>
				</html>";

				// Write the new text to the file, overwriting any existing content
				File.WriteAllText(filePath, newText);
				
                return false;
            }            
    }
}