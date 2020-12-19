# CreateFolders
Creates folders for OneDrive transfer of files using mover.io

I created a new domain so I could get the Standard Edition of Microsoft 365 and get Teams.  

After subscribing to Standard Edition, I was going to cancel my Family Edition, but I found out that I also got a new OneDrive with the new Office apps.  
I have a lot of stuff on my OneDrive because that is where Office tends to put them.  I also put many of my projects, such as the ones found in this repo, on OneDrive.  I won't even mention pictures and videos I do not want to lose. 

Customer Support at Microsoft, who recently bought Mover.io, told me that they could transfer the file, but that their transfer agent does not create directories and subdirectories on the new OneDrive, but just dumps the files into the root folder.  He said that if Mover.io finds the folder on the new OneDrive, it will copies the old files to the full path and put them into the correct directories.  

So I wrote this quick and dirty program to create a folder hierarchy on the new one drive that matches the folder structure on the old OneDrive.

I hope this little utility might be of use to someone else as it demostrates both folder creation and recursion.  :0)
