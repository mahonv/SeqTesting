Run a Seq Server

```bash
docker run --name seq --rm -d -e ACCEPT_EULA=Y -p 80:80 -p 5341:5341 datalust/seq
```

Connect to your Seq Server to check logs

http://localhost/#/events?range=1h