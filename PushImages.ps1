param([String] $Repo, [String] $UserId, [String] $Password, [String] $Version)
docker login $Repo --username $UserId --password $Password
docker tag valuenethub:$Version $Repo/valuenethub:$Version
docker push $Repo/valuenethub:$Version
