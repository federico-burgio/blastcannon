# BlastCannon App
This app was created for the Microservices class @ UniMe.

## Build docker image
### Login into docker registry (you need an account @ hub.docker.com)
docker login

### Build the image
docker build . --rm -f Dockerfile -t blastcannon:latest

### Tag it and send it to the registry
docker tag blastcannon blastcannon:latest & docker push blastcannon:latest

### Run on your local docker
docker run -d -p 5000:5000 blastcannon:latest

## Run it with Minikube
### Create deployment
kubectl run blastcannon blastcannon:latest --port=5000

### Create a service for the deployment
kubectl expose deployment blastcannon --type=NodePort

### Get the url of the service
minikube service blastcannon --url


## Useful Links
### Docker
https://www.docker.com

### Docker Hub - Official Registry
https://hub.docker.com

### Visual Studio Code
https://code.visualstudio.com

## Credits
Federico Burgio - Lead Architect @ BaxEnergy
http://www.baxenergy.com
http://www.freemindfoundry.com