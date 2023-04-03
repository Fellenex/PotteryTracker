# PotteryTracker
App for tracking pottery progress



## Idea
I love tracking things by writing in journals, but pottery pieces often go through many times of being touched, at fairly distant intervals.
Especially as someone who uses a local shared pottery studio and can only attend once/week based on their schedule, it can
    take months to go from a lump of clay to a finished product.
(Even longer if there's any delay before glazing, something I find myself only doing in bulk.)
Not only that, but you interact with such a piece at least three times (throwing, trimming, glazing)
    and with two firings inbetween before it's finished.


## Scripts

1. PotteryEntryModel
   - Keeps track of a PotteryEntry object to keep track of the data in the UI input fields on the PotteryEntryEdit screen
   - 
2. PotteryEntryEditor
   - Has a function to append to the end of a JSON file (accepts a List<PotteryEntry> and a PotteryEntry (append, reserialize))
     - Overload by accepting a JSON instead of a List<PotteryEntry>?
   - Has a function to modify an existing top-level element of a JSON file (accepts a List<PotteryEntry> and a PotteryEntry (modify, reserialize);
     - Overload by accepting a JSON instead of a List<PotteryEntry>?
   - Has a function to deserialize PotteryEntry JSONs
   - Has a function to reserialize PotteryEntry JSONs

## Features Roadmap
1. Can create a new pottery entry, which is stored + loaded from a .json file
   - Create the UI for an EntryPanel
     - id - should be a unique number among the entries. Maintains a lineage because it can't be changed
     - Label + label (default "Pot")
     - Image
     - Number of pieces + label (default 1)
     - Thrown date + label (default current date)
     - Trimmed date + label
     - Glazed date + label
     - Clay name(s) + label
     - Glaze name(s) + label
     - Notes text field
   - Pressing "New Entry" on the EntryListPanel
     - activates the EntryPanel, which appears overtop
     - sends a PotteryEntry object (in this case, null) to the PotteryEntryCreation script.
   - Pressing "Save" on the EntryPanel
     - adds the PotteryEntry object to a .json
     - lets the script which loads the .json for the Entry List display know that the .json should be re-read to update the list
     - Deactivates the EntryPanel UI object
  
2. Can edit existing pottery entries, re-using the creation UI
   - Double-click on a pottery entry to open the same EntryPanel, except this time it's preloaded with the values from this pottery entry
     - All the values should just be automatically filled in, and also editable
   - "If prior entry loaded" logic for the save button.
     - Instead of automatically appending to the .json, we should check whether an ID was supplied when the object got activated
       - Receive a PotteryEntry object via event listener, (send null on entry creation) and if the id is supplied, then edit the existing entry.
  
3. Predetermined set of bulk edits
   - select many, mark all as trimmed/glazed
   - select many, change the thrown/trimmed/glazed date
4. Can filter the list of displayed pottery entries based on date range, label, clay body, glazed used, notes
5. Can upload an image for a pottery entry
   - Draw an image on a little canvas
   - Take a picture
   - Upload a picture
   - (Should all also be possible as a bulk edit option).
100.   Getting it actually published on Android app store