# Godot + Llama2
This is an open-source project meant to connect godot with the Meta LLama2 Large language model using Python websockets. It's a client-server architecture, useful for online or offline games

## Table of Contents

- [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation)
- [Usage](#usage)
    - [Running the Server](#running-the-server)
    - [Running the godot Client](#running-the-godot-client)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Getting Started

### Prerequisites

- Python 3.6+
- Godot Mono (C#)

### Installation

1. Create a new project in Unity
2. Clone this repository
3. Open the Godot project in the godotClient folder
4. Then enter to the "llamaServer" folder
5. Is very useful to create a virtual enviroment, install the dependencies with
   ```pip install -r requirements.txt```
6. Copy the .env.test into a .env file and changit as you want

## Usage

### Running the Server

Start the server
    ```
    python server.py
    ```
  
If working correctly, the server should display `Listen in: localhost:8765`

### Running the Unity Client

1. Open the `Godot project` folder with the Godot Mono Editor
2. Open the sample scene
3. Press the play button to start the client

## Contributing

Your contributions are greatly appreciated! Please follow these steps:

1. Fork the project
2. Create your feature branch `git checkout -b feature/MyFeature`
3. Commit your changes `git commit -m "my cool feature"`
4. Push to the branch `git push origin feature/MyFeature`
5. Open a Pull Request

## License

Every basecode made by my is under MIT licence

<div align="center">
<h3 align="center">Let's connect 😋</h3>
</div>
<p align="center">
<a href="https://www.linkedin.com/in/hector-pulido-17547369/" target="blank">
<img align="center" width="30px" alt="Hector's LinkedIn" src="https://www.vectorlogo.zone/logos/linkedin/linkedin-icon.svg"/></a> &nbsp; &nbsp;
<a href="https://twitter.com/Hector_Pulido_" target="blank">
<img align="center" width="30px" alt="Hector's Twitter" src="https://www.vectorlogo.zone/logos/twitter/twitter-official.svg"/></a> &nbsp; &nbsp;
<a href="https://www.twitch.tv/hector_pulido_" target="blank">
<img align="center" width="30px" alt="Hector's Twitch" src="https://www.vectorlogo.zone/logos/twitch/twitch-icon.svg"/></a> &nbsp; &nbsp;
<a href="https://www.youtube.com/channel/UCS_iMeH0P0nsIDPvBaJckOw" target="blank">
<img align="center" width="30px" alt="Hector's Youtube" src="https://www.vectorlogo.zone/logos/youtube/youtube-icon.svg"/></a> &nbsp; &nbsp;
