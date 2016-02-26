var fs  = require("fs");
fs.readFileSync(process.argv[2]).toString().split('\n').forEach(function (line) {
    if (line != "") {
        result = 0;
        for(i=0; i<line.length;i++){
            result += parseInt(line.substring(i,i+1));
        }
        console.log(result);
    }
});
