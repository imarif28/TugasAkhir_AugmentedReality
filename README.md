# Augmented Reality Application

## Project Description
This project demonstrates the implementation of an Augmented Reality (AR) application using Unity and AR Foundation. The application provides interactive 3D object visualization and manipulation in real-world environments through marker-based or markerless AR tracking. The project was developed as part of the Multimedia Systems course.

## Features
- Real-time 3D object rendering in augmented reality environment
- Marker-based AR tracking for stable object placement
- Interactive 3D model manipulation including rotation, scaling, and positioning
- Touch gesture controls for enhanced user interaction
- Cross-platform compatibility for Android and iOS devices
- Real-time lighting and shadow effects integration
- Multiple AR scene management and object switching
- Performance optimization for mobile devices

## Technologies Used
- **Game Engine:** Unity 2022.3 LTS
- **AR Framework:** AR Foundation
- **Programming Language:** C#
- **Platform:** Android/iOS
- **Development Environment:** Unity Editor
- **Version Control:** Git

## How the Program Works

### Main AR System
1. **Camera Initialization:**
   - Initializes AR camera and session management
   - Configures tracking modes and camera settings
   - Establishes coordinate system for AR space

2. **Tracking System:**
   - Detects and tracks AR markers or plane surfaces
   - Maintains tracking stability through environmental mapping
   - Handles tracking loss and recovery scenarios

3. **Object Management:**
   - Instantiates 3D objects at tracked positions
   - Manages object lifecycle and memory allocation
   - Handles multiple simultaneous AR objects

### Core Components

#### AR Session Manager
1. **Session Control:**
   - Manages AR session lifecycle (start, pause, resume, stop)
   - Handles session configuration and feature enabling
   - Monitors session state and provides feedback

2. **Tracking Configuration:**
   - Configures plane detection settings
   - Sets up marker tracking parameters
   - Manages tracking quality and performance

#### Object Interaction System
1. **Touch Input Handler:**
   - Processes touch gestures for object manipulation
   - Implements pinch-to-zoom functionality
   - Handles drag and rotation controls

2. **Physics Integration:**
   - Applies realistic physics to AR objects
   - Handles collision detection between virtual and real objects
   - Manages object constraints and boundaries

#### UI Management System
1. **AR Interface:**
   - Displays tracking status and AR controls
   - Provides object selection and manipulation tools
   - Shows performance metrics and debugging information

2. **Menu System:**
   - Implements settings and configuration panels
   - Manages scene switching and object library
   - Handles user preferences and customization

## Core Scripts and Functionality

### AR Controller Script
- Manages main AR functionality and scene coordination
- Handles camera tracking and object placement
- Coordinates between AR Foundation and Unity systems
- Implements error handling and fallback mechanisms

### Object Spawner Script
- Controls 3D object instantiation and positioning
- Manages object pool for performance optimization
- Handles object destruction and cleanup
- Implements object selection and highlighting

### Interaction Manager Script
- Processes user input and gesture recognition
- Translates touch input to 3D transformations
- Manages object interaction states and feedback
- Implements multi-touch support for complex gestures

### UI Controller Script
- Manages user interface elements and updates
- Handles menu navigation and settings
- Displays real-time information and notifications
- Coordinates UI with AR system state

## AR Controls
- **Touch:** Tap to place objects at detected surfaces
- **Pinch:** Pinch to scale objects up or down
- **Drag:** Drag to move objects in 3D space
- **Rotate:** Two-finger rotation to rotate objects
- **Long Press:** Long press to access object options menu

## System Requirements
- **Android:** Android 7.0 (API level 24) or higher with ARCore support
- **iOS:** iOS 11.0 or higher with ARKit support  
- **RAM:** Minimum 3GB RAM recommended
- **Storage:** 500MB available storage space
- **Camera:** Rear-facing camera with autofocus

## Program Output
1. **AR Session Initialization:**
   - Displays camera view with tracking indicators
   - Shows session status and availability messages

2. **Object Placement:**
   - Renders 3D objects anchored to real-world surfaces
   - Provides visual feedback for successful placement

3. **Interactive Manipulation:**
   - Real-time object transformation responses
   - Visual indicators for active interactions

4. **Performance Monitoring:**
   - Frame rate display and performance metrics
   - Memory usage and optimization indicators

## Installation and Usage
1. **Development Setup:**
   - Install Unity 2022.3 LTS or later
   - Import AR Foundation package from Package Manager
   - Configure XR Plug-in Management for target platform

2. **Project Configuration:**
   - Set up Android SDK and NDK for Android builds
   - Configure iOS build settings and provisioning profiles
   - Import 3D models and textures into Assets folder

3. **Build and Deploy:**
   - Select target platform in Build Settings
   - Configure player settings for AR capabilities
   - Build and install on compatible AR device

4. **Usage Instructions:**
   - Launch application on AR-capable device
   - Point camera at well-lit flat surfaces
   - Tap to place objects when tracking is stable
   - Use touch gestures to interact with placed objects

## Project Structure
```
Assets/
├── Scripts/
│   ├── ARController.cs
│   ├── ObjectSpawner.cs
│   ├── InteractionManager.cs
│   └── UIController.cs
├── Prefabs/
│   ├── AR Objects/
│   └── UI Elements/
├── Models/
│   ├── 3D Objects/
│   └── Textures/
├── Scenes/
│   ├── MainAR.unity
│   └── MenuScene.unity
└── Materials/
    └── AR Materials/
```

## Known Issues and Limitations
- Performance may vary on older devices with limited processing power
- Tracking accuracy depends on environmental lighting conditions
- Some devices may experience tracking drift in low-texture environments
- Battery consumption increases during extended AR sessions

## Future Enhancements
- Multi-user AR collaboration features
- Cloud anchor support for persistent AR content
- Advanced occlusion handling for realistic object interaction
- Machine learning integration for improved object recognition

## Download Links
- **APK File and AR Markers:** https://drive.google.com/drive/folders/1jN8O2AOxIt31DC2jq3p3NcIdusP5J-9Q?usp=sharing

## Quick Start Guide
1. **Download APK:**
   - Access the Google Drive link above
   - Download the APK file to your Android device
   - Enable "Install from Unknown Sources" in device settings

2. **Install Application:**
   - Install the downloaded APK on your Android device
   - Grant camera permissions when prompted

3. **Download AR Markers:**
   - Download marker images from the same Google Drive folder
   - Print markers on paper or display on screen for testing

4. **Start AR Experience:**
   - Launch the application
   - Point camera at printed markers to view AR content

## Developer
- **Name:** Ilham Muhammad Arif
- **Course:** Multimedia Systems
- **Institution:** Politeknik Negeri Semarang
- **Year:** 2024
