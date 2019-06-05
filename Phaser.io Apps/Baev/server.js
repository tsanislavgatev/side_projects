const http = require("http");
var fs = require('fs');
const server = http.createServer((req, res) => 
    { fs.readFile('PONG.html', ( err, data) => {
        res.writeHead(200, {'Content-Type': 'text/html', 'Content-Length':data.length});
        res.write(data);
        res.end();
    })});
    
server.listen('9969');