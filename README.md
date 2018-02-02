# RXPHelloWorld

This app works on React Native (iOS, Android) and web. Most of the app's code is contained in `App.fs`.

The commands in the instructions below assume you are in the root of this repo.

### Initial Setup

- Run `yarn install`. This fetches the dependencies.

### Building for Web

- Run `yarn web-watch`. This transpiles the ES6 code and retranspiles it whenever any files are changed.
- Open `index.html` in your browser to view the result.

### Building for React Native

- Option 1:
	- In a command prompt run `yarn start`. This starts the React Native Packager.
	- Use Xcode or Android Studio to build and deploy the native app code just like you would with any other React Native project.
- Option 2
	- In a command prompt run `yarn run android` or `yarn run ios`. This starts the React Native Packager and deploys your application to the appropriate platform.
