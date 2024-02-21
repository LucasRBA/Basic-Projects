 
for i in {1..12}; do
    # Create folder with the name Solution<Number>
    folder_name="Solution$i"
    mkdir "$folder_name"

    # Print a message indicating the folder creation
    echo "Folder $folder_name created."
done

echo "Folders SolutionOne through SolutionTwelve have been created."
