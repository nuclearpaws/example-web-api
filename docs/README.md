# Example Web API

## Overview

This is just a simple .net 6.0 web api.

## Installation

Build the docker file:
```
docker build -f Dockerfile -t example-web-api .
```

Run the docker image:
```
docker run --name example-web-api -p 8001:443 -p 8000:80 -d example-web-api
```
