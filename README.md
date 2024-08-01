# streamer.bot specialcounter

A simple c# code to execute in the streamer.bot to trigger a special action when a global var hits a given requirement like the dividability by 25 in this case but you can insert every requirement you want to. In case the requirement gets true a source is made visible and after a given time tuned back invisible using the socket integrated in OBS. The code also generates a HTML file that contains a text with the var_name and the current var_count that you can use as a websource in obs. Necessary for that is a small plugin for OBS that periodically reads out the HTML file

Introduction:

Step 1: Create a global var in your streamer.bot by clicking "Variables" at the top, right click then "Add Variable", give the variable a name and a starting value and check the "Auto Type" box

Step 2: Create a HTML file named index.html in a folder of your choice on your pc and fill in with the given HTML code

Step 3: Change the two name expressions in the code into the name of the counter that is seen by your viewers and change the content of the fourth href that says "https://fonts.googleapis.com/css2?family=New+Rocker&display=swap" into a font you like from https://fonts.google.com/

Step 4: Create a style.css file in the same folderand fill in the given CSS code

Step 5: Change the font to the same google font as above and adjust the options font-size and color you can also change the size in pixel and the color as HEX. For the color I recommend https://encycolorpedia.com/

Step 6: Copy the code and put it into a execute code sub-action in your streamer.bot

Step 7: Change the var_name in the HTML code into the new variable name that you just entered as the new variable in your bot, change the HTML file location into the path of your new HTML file, change name in the HTML part of the code into whatever the variable should be called in the obs browsersource seen by your viewers and set the scene and source options to the scene and source you want to be changed by hitting the requirement. At the end you can code the reqierement to whatever you want it to be

Step 8: Install the automated browsersource refreshing by downloading it from the following website and following the installation guide https://obsproject.com/forum/resources/xobsbrowserautorefresh-timed-automatic-browser-source-refreshing.1677/

Step 9: Create a new OBS browsersource choose local file and select your index.html file.

Step 10: Create a new filter on the browsersource, select the auto refreshing and configure the timer as you want
