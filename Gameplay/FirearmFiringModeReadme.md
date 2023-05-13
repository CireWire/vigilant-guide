# Firearm Firing Mode Transition

This Unity C# script allows a firearm in a game to transition between full auto and burst fire firing modes. It provides a customizable burst fire functionality with adjustable burst count and delay between shots.

## Getting Started

### Prerequisites

To use this script, you'll need:

- Unity game engine (version 2018.3 or later)
- Basic knowledge of Unity and C#

### Installation

1. Create a new Unity project or open an existing project.
2. Copy the contents of the provided script into a new C# script file.
3. Attach the script to the GameObject representing your firearm in the Unity Editor.
4. Set up the appropriate input bindings for firing in the Unity Input Manager.
5. Customize the `Fire()` method to implement the actual firing logic for your firearm.

## Usage

1. Ensure that the script is attached to the GameObject representing your firearm.
2. Set the initial firing mode (FullAuto or Burst) in the inspector by adjusting the `currentFiringMode` variable.
3. Adjust the burst fire settings by modifying the `burstFireCount` and `burstFireDelay` variables.
4. Run the game in the Unity Editor or build and deploy the game to your desired platform.
5. Press and hold the designated fire button (`Fire1` in this example) to simulate firing.
6. Observe the different firing behaviors based on the selected firing mode.

## Customization

- Modify the `Fire()` method to implement the actual firing logic specific to your firearm. Replace the debug log with your custom firing code.
- Adjust the burst fire settings (`burstFireCount` and `burstFireDelay`) to achieve the desired burst fire behavior.
- Extend the `FiringMode` enum with additional firing modes if needed.

## Contributing

Contributions to this script are welcome. If you have suggestions for improvements or find any issues, please feel free to open an issue or submit a pull request.

## License

This script is licensed under the [MIT License](LICENSE). You are free to use, modify, and distribute the code in your projects.

## Acknowledgments

- This script was created using Unity, a powerful game engine developed by Unity Technologies.
- Thanks to the Unity community for their valuable resources and contributions.

