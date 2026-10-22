# First Game

First Game is a Unity obstacle-course prototype. The player moves forward automatically, can steer sideways, earns a score based on forward progress, and advances through a short sequence of levels after reaching each finish line.

## Features

- Automatic forward movement with keyboard-based lateral control
- Obstacle collision and fall detection
- Automatic level restart after failure
- Position-based score display
- Level-complete UI and sequential scene progression
- Menu and credits scenes

## Controls

| Action | Input |
| --- | --- |
| Move left | `A` |
| Move right | `D` |

## Requirements

- Unity `6000.3.8f1`
- Universal Render Pipeline `17.3.0`

The exact editor version is recorded in `ProjectSettings/ProjectVersion.txt`. Unity package versions are locked in `Packages/packages-lock.json`.

## Getting Started

1. Clone the repository.
2. Open Unity Hub and choose **Add project from disk**.
3. Select the repository root.
4. Open the project with Unity `6000.3.8f1` and allow Unity to restore packages and regenerate local cache files.
5. Open `Assets/Scenes/Menu.unity` and enter Play mode.

## Scene Order

The enabled build scenes are:

1. `Menu`
2. `Level01`
3. `Level02`
4. `Level03`
5. `Credits`

## Project Structure

```text
Assets/
  Animation/        Animation clips and controllers
  Material/         Materials and physics materials
  Prefabs/          Reusable game objects and UI prefabs
  Scenes/           Menu, gameplay levels, and credits
  Script/           Gameplay and UI scripts
  Settings/         Universal Render Pipeline settings
Packages/           Unity package manifest and lock file
ProjectSettings/    Shared Unity project configuration
```

Unity-generated caches, local editor preferences, IDE files, build outputs, and signing material are intentionally excluded from version control. Unity `.meta` files remain tracked because they preserve asset GUIDs and references.

## Notes

- The current application version is `0.1.0`.
- Generated folders such as `Library`, `Temp`, `Obj`, `Logs`, and `UserSettings` do not need to be copied; Unity recreates them locally.
