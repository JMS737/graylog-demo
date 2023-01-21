# Graylog Instance
## Setup
Create a `.env` file in the same directory as the `docker-compose.yml` file with a secret and root user (called 'admin') password. See the `.example.env` file for an example.

## Running
To run graylog daemonized, run the following command.
``` bash
docker-compose up -d
```

The graylog portal should then be available on `http://localhost:9000`.

Note: The default user is `admin` and the password will be whatever you used to create the `GRAYLOG_ROOT_PASSWORD_SHA2` value in the `.env` file.