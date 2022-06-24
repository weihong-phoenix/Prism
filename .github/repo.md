# Prism Library Bug Report Reproduction Guide

First or all, thank you for reporting this potential bug. Here you will find more information about why we ask you for a reproducible example of the problem, and how to provide it.

## What is a reproduction?
A reproduction, reproducible example or just repro for short is the most basic code to demonstrate the issue that you're seeing. It's the simplest way to reproduce the issue.
Ideally, you should be able to reproduce the issue by just running the code in the project you have provided and see the problem. If any reproduction steps are needed, either note them in the issue or include them in the project somehow.

## Why do we ask for a reproducible example?
Depending on your project a codebase can be pretty big. The bigger your project, the more factors that can be of influence on a bug or issue that you might be seeing.
In order to be sure that this is something that is happening in Prism and not something in your code (or a combination of these things), it is super helpful to have a small sample that reproduces the issue. This way we can:

* better pinpoint the source of the issue;
* therefore, we can fix the issue faster;
* and we can make sure that the issue is not a false positive.

It also acts as a double-edged sword. When you take your code apart piece-by-piece in a new project, adding things back one by one, it will become very clear what different factors are at play here and you might discover that the issue might be something in your code. At the very least you will be able to provide a very detailed description of what you're seeing. That helps us get to the cause faster and resolve the issue quicker.

### I just want to report a bug, why do you want a reproduction?
We hear this a lot. We understand you're busy, we're all busy! A reproduction is not just about pleasing us or you doing our work. As already mentioned above, it will help you get a better understanding of where the issue is exactly. We've seen lots of cases where people realized, through a reproduction, that the solution was right within their reach. Regardless of it being a bug in Prism or not.

We like to see this as a team effort.

#### But I don't have time for this!
Please help us, help you! The Prism team works on Prism in their spare time, and for free, we cannot make time to try to reproduce your issues. This is an open-source project under the MIT license. Provided as-is, without any support or guarantees. We care about our project and therefore by extension also about your project. But realize that when you come onto our repo, maybe frustrated because things are not working and you just drop a one-liner, no reproduction, mentioning that you don't have the time, that's also not very motivating for us. On the other end of these GitHub issues are still people. People that are doing their best to move this project forward, people that do not enjoying seeing you being blocked.

Also consider how that comes across. If you don't have the time to report in detail what is going on, then really how important is the issue? If this is really important and blocking you, it would seem to make sense to prioritize getting us all the details to help resolve this faster. We are all here to help you. But remember that we don't know your project and we don't know any details, please help us understand and be nice.

## How to provide a reproduction project?
With a reproduction we want to rule out a couple of things:

* The issue is not in your code, but in the Prism Library;
* The issue has not been already resolved in the latest version of Prism which may not be the latest version available on NuGet.org;

Therefore we would like to propose the following steps to create a reproduction sample:

* Check if you are using the latest version of Prism and you can still reproduce the issue;
* If yes, please check any available preview versions of Prism and see if you can reproduce the issue;
* If you still can, please check to see if there are is an issue already opened on the repository for it;
  * If there is, see if you can add any more detail about your specific case, that might help to resolve it quicker. If you don't have any additional information, add an emoji to the first post of the issue so we know how many people are impacted by this.
* If there is no issue for it yet, please open one and provide detailed answers to everything in the New Issue form.

At this point we would love for you to include the reproduction.

* Start with a File > New project, in other words, a clean, new Prism project. Make sure that you are using the last version of Prism.
* Start extracting the code from your project, piece-by-piece, until you have reach the issue.
* Try to remove some code or make small changes to see how that influences the issue you're seeing. Remove any code that is not needed to reproduce the issue. This is noise and will interfere with getting to a cause and solution.
* Put the code on a GitHub repository and include that link in the issue that you're opening.

**Note: we can't accept any zip files attached to the issue.** If we need the code in a zip, we can get that from the GitHub repository. This will also make it easier to collaborate. If we think we spot something that doesn't look right, we can open a PR on your repro repo (😬) and you can easily see the differences.

## Big don'ts!
- Never put any sensitive information in your code. No API keys, credentials, personal information, etc.
- Never put any proprietary code in your reproduction. We are contractually not allowed to look at code that you do not own without bit legal hassles and NDA's.
- Never submit binaries (mostly covered by putting it on a GitHub repo)
- Do not reference external data-sources, this should rarely be needed.
- Always refer to concrete version numbers. Avoid saying "this happens in the latest version". We don't know if you're using a preview version or maybe you _think_ you're using the latest version but actually aren't. To avoid any confusion, always refer to exact version numbers.
- Do not confuse an open issue with paid support. If you require actual Enterprise Support please see Monthly or Yearly Support options with [AvantiPoint](https://avantipoint.com/developer/support)
