
# react-native-house-keeper-center

## Getting started

`$ npm install react-native-house-keeper-center --save`

### Mostly automatic installation

`$ react-native link react-native-house-keeper-center`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-house-keeper-center` and add `RNHouseKeeperCenter.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNHouseKeeperCenter.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNHouseKeeperCenterPackage;` to the imports at the top of the file
  - Add `new RNHouseKeeperCenterPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-house-keeper-center'
  	project(':react-native-house-keeper-center').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-house-keeper-center/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-house-keeper-center')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNHouseKeeperCenter.sln` in `node_modules/react-native-house-keeper-center/windows/RNHouseKeeperCenter.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using House.Keeper.Center.RNHouseKeeperCenter;` to the usings at the top of the file
  - Add `new RNHouseKeeperCenterPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNHouseKeeperCenter from 'react-native-house-keeper-center';

// TODO: What to do with the module?
RNHouseKeeperCenter;
```
  