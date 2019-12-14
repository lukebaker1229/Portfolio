#! python3
# quickWeather.py - Prints the current weather for a location from the command line.

import json, requests, sys

# Compute location from command line arguments.
if len(sys.argv) < 2:
    print('Welcome: weatherInformer.py current location')
    sys.exit()
currentLocation = ' '.join(sys.argv[1:])

# Download the JSON data from OpenWeatherMap.org's API
url ='http://api.openweathermap.org/data/2.5/forecast/daily?q=%s&cnt=3' % (currentLocation)
response = requests.get(url)
response.raise_for_status()

# Load JSON data into a Python variable.
weatherData = json.loads(response.text)

# Print weather descriptions.
w = weatherData['list']
print('Current weather in %s:' % (currentLocation))
print(w[0]['weather'][0]['main'], '-', w[0]['weather'][0]['description'])
print()
print('Tomorrow:')
print(w[1]['weather'][0]['main'], '-', w[1]['weather'][0]['description'])
print()
print('Day after tomorrow:')
print(w[2]['weather'][0]['main'], '-', w[2]['weather'][0]['description'])
