import * as uuid from "uuid/v1";

var guids: string[] = [uuid(), uuid()];

for (var i = 0; i < guids.length; i++) {
    console.log(guids[i]);
}
