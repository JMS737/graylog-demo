# Graylog
## Setup
Create a `.env` file (needs to be in the same directory as the `/graylog/docker-compose.yml` file) with a secret and root user password. See the `/graylog/.example.env` file for an example.

## Running
To run graylog daemonized, run the following command.
``` bash
docker-compose up -d
```

The graylog portal should then be available on `http://localhost:9000`.

Note: The default user is `admin` and the password will be whatever you used to create the `GRAYLOG_ROOT_PASSWORD_SHA2` value in the `.env` file.

# Sources
- [Graylog Github](https://github.com/Graylog2/docker-compose)
- [Building .NET Images](https://docs.docker.com/language/dotnet/build-images/)
- [Docker Health Checks](https://docs.docker.com/engine/reference/builder/#healthcheck)
- [Docker Graylog Logging Driver](https://docs.docker.com/config/containers/logging/gelf/)