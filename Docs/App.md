# App
![overview](charts/animation%20flow.svg)

- [App](#app)
  - [Rooms](#rooms)
    - [Room](#room)
    - [Time of day](#time-of-day)
  - [Scenes](#scenes)
    - [Scene](#scene)
    - [Time of day](#time-of-day-1)
    - [Mutation](#mutation)
  - [Layout](#layout)
    - [Actuators](#actuators)
    - [Layout Data](#layout-data)
  - [Patterns](#patterns)
  - [Animated](#animated)
    - [Controllers](#controllers)
    - [Animations](#animations)
  - [Animation Overlay](#animation-overlay)

## Rooms
The collection of rooms stored inside the app

### Room
A single rooms stores it layout, devices and services it needs:
- hue brigde
- bluetooth lamps
- spotify
- webhooks
- resources

A room mostly consists out of settings and a list of scenes the user can select.
A time of day slider used for all the scenes

### Time of day
The time of day in a room is a global slider that specifies what time it is in the game world

## Scenes
A collection of scenes set by the user that is aviable per room

### Scene
A single scenes stores the following:
- what patterns are located through the layout.
- What animations controllers are used.
- What mutations are aviable and which are on/off

If a scene is selected, the animation runner should be on.

### Time of day
The time of day in a scene is originally set from the rooms time of day. But in the scene it also stores what type of animation to use what effects / fxs

### Mutation
A mutation is an overlay of animations/controllers 

## Layout
A definition of the room, and the distance of actuators from the center (the center being the playing table)

### Actuators
Devices that can either handle light, sound or events.

### Layout Data
This storage of colours/sounds at specific points in the room. This is the collection of data received from animations and others.

## Patterns
Can be anything from dynamic to static sounds, based either on gradients or whatever.
But it should output based upon the animation time a colour

## Animated
A process of controllers and/or animations to play.

### Controllers
A controller determines based on conditions what animations to play or how to switch to another animation.

### Animations
An animation tells what pattern to have play/blend. or specific global colours / sounds.

## Animation Overlay
An animation overlay is a process of overlaying multiple animations and their colours / sounds into 1 single output

