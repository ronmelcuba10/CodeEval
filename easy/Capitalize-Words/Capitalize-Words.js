var fs  = require("fs");
fs.readFileSync(process.argv[2]).toString().split('\n').forEach(function (line) {
    if (line != "") {
        words = line.split(" ");
        result = "";
        for(i=0;i<words.length;i++){
            result = result + words[i].substring(0,1).toUpperCase() + words[i].substring(1,words[i].length) + " ";
        }
        console.log(result);
    
    }
});
