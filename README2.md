# SavePathAndReturn Project 

(both CMD and EXE versions)

This command line utility saves the current directory
in an environment variable and then quickly restores 
it when needed. 

## Getting Started

Copy the the necessary files to a folder that is in 
the path variable. That is all you need to do at this
point. See deployment for notes on how to deploy 
the project on a live system.

### Prerequisites

What things you need to install the software and how to install them

```
If you are using a Windows 7 computer, you will need to
make sure that you have SETX.exe in your path. This is 
included in the latest service pack.
```

### Installing

A step by step series of examples that tell you how to get a development env running

1. Download the zip file
2. Unzip the files to a location in the %PATH% folder structure.
3. Navigate to a folder whose location you want to save.
4. Type in `SavePath` and press Enter.
5. Navigate away from the folder.
6. Type in `Return` and press Enter.
7. The program will return you to the saved folder.

```
C:\> cd "\Program Files"
C:\Program Files> SavePath 
C:\Program Files> cd \
C:\> Return
C:\Program Files>
```
## Running the tests

Explain how to run the automated tests for this system

### Break down into end to end tests

Explain what these tests test and why

```
Give an example
```

### And coding style tests

Explain what these tests test and why

```
Give an example
```

## Deployment

Add additional notes about how to deploy this on a live system

## Built With

* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - The web framework used
* [Maven](https://maven.apache.org/) - Dependency Management
* [ROME](https://rometools.github.io/rome/) - Used to generate RSS Feeds

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Billie Thompson** - *Initial work* - [PurpleBooth](https://github.com/PurpleBooth)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc
