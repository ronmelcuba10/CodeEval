var fs  = require("fs");
fs.readFileSync(process.argv[2]).toString().split('\n').forEach(function (line) {
    if (line != "") {
        var pos = line.indexOf(",");
        var f = parseInt(line.substring(0,pos));
        var s = parseInt(line.substring(pos+1));
        var num = Math.floor(f/s);
        console.log(f - num*s);
    }
});
