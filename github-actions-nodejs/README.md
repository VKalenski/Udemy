# **GitHub-Actions**

>[1. Git](#git)
>
>[2. GitHub](#github)
>
>[3. Git Repositories](#git-repositories)
>
>[4. Working with Commits](#working-with-commits)
>
>[5. Understanding Staging](#understanding-staging)
>
>[6. Key Commands](#key-commands)
>
>[7. Forking & Pull Requests](#forking-and-pull-requests)
>
>[8. GitHub Actions Fundamentals](#github-actions-fundamentals)
>
>[9. Actions](#actions)
>
>[10. Cancelling & Skipping Workflow Runs](#cancelling-and-skipping-workflow-runs)
>
>[11. Job Data & Outputs](#job-data-and-outputs)
>
>[12. Environment Variables & Secrets](#environment-variables-and-secrets)
>
>[13. Controlling Execution Flow](#controlling-execution-flow)
>
>[14. Using Containers](#using-containers)
>
>[15. Building Custom Actions](#building-custom-actions)
>
>[16. Types of Custom Actions](#types-of-custom-actions)
>
>[17. Permissions & Security](#permissions-and-security)
>
>[18. Links & Commands](#links-and-commands)

---

### **Git**

Git is a (free) version control system (tool) for managing source code changes
- Save code snapshots ("commits");
- Work with alternative code versions ("branches");
- Move between branches & commits.

With Git, you can easily roll back to older code snapshots or develop new features without breaking production code.

#### [🔼 Back to top](#github-actions)

---

### **GitHub**

GitHub is a cloud Git repository & services provider. Store & manage Git repositories.

1. **Cloud Git repository storage ("push" & "pull"):**
- Backup, work across machines & work in teams;
- Public & private, team management & more.

2. **Code management & collaborative development:**
- Via "Issues", "Projects", "Pull Requests" & more.

3. **Automation & CI/CD:**
- Via GitHub Actions, GitHub Apps & more.

4. **GitHub Actions Alternatives:**
- Jenkins;
- GitLab CI/CD;
- Azure Pipelines;
- AWS CodePipeline.

#### [🔼 Back to top](#github-actions)

---

### **Git Repositories**

1. **Git features can be used in projects with Git repositories:**
- A repository is a folder used by Git to track all changes of a given project: Git commands require a repository in a project;
- Create Git repositories via git init: only required once per folder/project;
- Some projects initialize Git for you: e.g. React projects.

2. **Cloud storage for your Git repositories (public/private):**
- Backup, cross-device usage, collaboration;
- "Connected" to local Git repositories via git remote add;
- Local commits are uploaded via git push;
- Remote commits are downloaded via git pull.

#### [🔼 Back to top](#github-actions)

---

### **Working with Commits**

Commits are "code snapshots".

> **Create Commits:**
```
git add <file(s)>
```

> **Move between Commits:**
```
git checkout <id>
```

> **Undo Commits:**
```
git revert <id>
```

> **Undo changes by deleting all commits since <id>**
```
git reset --hard <id>
```


#### [🔼 Back to top](#github-actions)

---

### **Understanding Staging**

Staging controls which changes are part of a commit
- With staging, you can make sure that not all code changes made are added to a snapshot;
- If all changes should be included, you can use git add . to include all files in a Git repository.

#### [🔼 Back to top](#github-actions)

---

### **Key Commands**

|Commands|Descriptions|
|:--|:--|
|git init|Initialize a Git repository (only required once per project)|
|git add <file(s)>|Stage code changes (for the next commit)|
|git commit -m "Message"|Create a commit for the staged changes (with a message)|
|git status|Get the current repository status (e.g., which changes are staged)|
|git log|Output a chronologically ordered list of commits|
|git checkout <id>|Temporarily move back to commit <id>|
|git revert <id>|Revert the changes of commit <id> (by creating a new commit)|
|git reset <id>|Undo commit(s) up to commit <id> by deleting commits|

#### [🔼 Back to top](#github-actions)

---

### **Forking and Pull Requests**

1. **Repository Forking:**
- Creates a standalone copy of a repository;
- Can be used to work on code without affecting the original repository.

2. **Pull Requests:**
- Requests merging code changes into a branch;
- Can be based on a forked repository or another branch from the same repository;
- Pull requests allow for code reviews before merging changes.

#### [🔼 Back to top](#github-actions)

---

### **GitHub Actions Fundamentals**

Key Elements: Workflows, Jobs, Steps.

1. **Workflows**
- Attached to a GitHub repository;
- Contain one or more Jobs;
- Triggered upon Events.

2. **Jobs**
- Define a Runner (execution environment);
- Contain one or more Steps;
- Run in parallel (default) or sequential;
- Can be conditional.

3. **Steps**
- Execute a shell script or an Action;
- Can use custom or third-party actions;
- Steps are executed in order;
- Can be conditional.

#### [🔼 Back to top](#github-actions)

---

### **Actions**

1. **Action:**
- A (custom) application that performs a (typically complex) frequently repeated task;
- You can build your own Actions but you can also use official or community Actions.

2. **Event:**
- Push;
- Pull_request;
- etc.

3. **By default, Pull Requests based on Forks do NOT trigger a workflow:**
- Reason: Everyone can fork & open pull requests;
- Malicious workflow runs & excess cost could be caused;
- First-time contributors must be approved manually.

#### [🔼 Back to top](#github-actions)

---

### **Cancelling and Skipping Workflow Runs**

1. **Cancelling:**
- By default, Workflows get cancelled if Jobs fail;
- By default, a Job fails if at least one Step fails;
- You can also cancel workflows manually.

2. **Skipping:**
- By default, all matching events start a workflow;
- Exceptions for “push” & “pull_request”;
- Skip with proper commit message.

#### [🔼 Back to top](#github-actions)

---

### **Job Data and Outputs**

1. **Artifacts:**
- Jobs often product assets that should be shared or analyzed;
- Examples: Deployable website files, logs, binaries etc.;
- These assets are referred to as “Artifacts” (or “Job Artifacts”);
- GitHub Actions provides Actions for uploading & downloading.

2. **Outputs:**
- Besides Artifacts, Steps can product and share simple values;
- These outputs are shared via ::set-output;
- Jobs can pick up & share Step outputs via the steps context;
- Other Jobs can use Job outputs via the needs context.

3. **Caching:**
- Caching can help speed up repeated, slow Steps;
- Typical use-case: Caching dependencies;
- But any files & folder can be cached;
- The cache Action automatically stores & updates cache values (based on the cache key);
- Important: Don’t use caching for artifacts!

#### [🔼 Back to top](#github-actions)

---

### **Environment Variables and Secrets**

1. **Environment Variables:**
- Dynamic values used in code (e.g., database name);
- May differ from workflow to workflow;
- Can be defined on Workflow-, Job- or Step-level;
- Can be used in code and in the GitHub Actions Workflow;
- Accessible via interpolation and the env context object;
- Some environment variable values should never be exposed: example - Database access password.

2. **Secrets:**
- Some dynamic values should not be exposed anywhere;
- Examples: Database credentials, API keys etc.;
- Secrets can be stored on Repository-level or via Environments;
- Secrets can be referenced via the secrets context object;
- Different Secrets for different environments (e.g., different database passwords).

3. **GitHub Actions Environments:**
- Jobs can reference different GitHub Actions Environments;
- Environments allow you to set up extra protection rules;
- You can also store Secrets on Environment-level.

#### [🔼 Back to top](#github-actions)

---

### **Controlling Execution Flow**

1. **Conditional Jobs & Steps:**
- Control Step or Job execution with if & dynamic expressions
- Change default behavior with failure(), success(), cancelled() or always()
- Use continue-on-error to ignore Step failure

2. **Matrix Jobs:**
- Run multiple Job configurations in parallel
- Add or remove individual combinations
- Control whether a single failing Job should cancel all other Matrix Jobs via continue-on-error

3. **Reusable Workflows:**
- Workflows can be reused via the workflow_call event
- Reuse any logic (as many Jobs & Steps as needed)
- Work with inputs, outputs and secrets as required


**Special Conditional Functions**

1. **failure():**
- Returns true when any previous Step or Job failed

2. **success():**
- Returns true when none of the previous steps have failed

3. **always():**
- Causes the step to always execute, even when cancelled

4. **cancelled():**
- Returns true if the workflow has been cancelled

#### [🔼 Back to top](#github-actions)

---

### **Using Containers**

1. **Containers:**
- Packages of code + execution environment;
- Great for creating re-usable execution packages & ensuring consistency;
- Example: Same environment for testing + production.

2. **Containers for Jobs:**
- You can run Jobs in pre-defined environments;
- Build your own container images or use public images;
- Great for Jobs that need extra tools or lots of customization.

3. **Service Containers:**
- Extra services can be used by Steps in Jobs;
- Example: Locally running, isolated testing database;
- Based on custom images or public / community images.

4. **GitHub Actions Runners**
- Your containerized Job is hosted by the Runner;
- Steps execute inside the container;
- You can also create Services: Utility containers used by your Steps (Example: Testing Database).

#### [🔼 Back to top](#github-actions)

---

### **Building Custom Actions**

1. **Simplify Workflow Steps:**
- Instead of writing multiple (possibly very complex) Step definitions, you can build and use a single custom Action;
- Multiple Steps can be grouped into a single custom Action.

2. **No Existing (Community) Action:**
- Existing, public Actions might not solve the specific problem you have in your Workflow;
- Custom Actions can contain any logic you need to solve your specific Workflow problems.

#### [🔼 Back to top](#github-actions)

---

### **Types of Custom Actions**

1. **What & Why?**
- Simplify Workflows & avoid repeated Steps;
- Implement logic that solves a problem not solved by any;
- publicly available ActionCreate & share Actions with the Community.

2. **Composite Actions**
- Create custom Actions by combining multiple Steps;
- Composite Actions are like "Workflow Excerpts";
- Use Actions (via uses) and Commands (via run) as needed.

3. **JavaScript & Docker Actions**
- Write Action logic in JavaScript (NodeJS) with @actions/toolkit;
- Alternatively: Create your own Action environment with Docker;
- Either way: Use inputs, set outputs and perform any logic.

4. **JavaScript Actions**
- Execute a JavaScript file;
- Use JavaScript (NodeJS) + any packages of your choice;
- Pretty straightforward (if you know JavaScript).

5. **Docker Actions**
- Create a Dockerfile with your required configuration;
- Perform any task(s) of your choice with any language;
- Lots of flexibility but requires Docker knowledge.

#### [🔼 Back to top](#github-actions)

---

### **Permissions and Security**

1. **Script Injection:**
- A value, set outside a Workflow, is used in a Workflow;
- Example: Issue title used in a Workflow shell command;
- Workflow / command behavior could be changed.

2. **Malicious Third-Party Actions:**
- Actions can perform any logic, including potentially malicious logic;
- Example: A third-party Action that reads and exports your secrets;
- Only use trusted Actions and inspect code of unknown / untrusted authors.

3. **Permission Issues:**
- Consider avoiding overly permissive permissions;
- Example: Only allow checking out code (“read-only”);
- GitHub Actions supports fine grained permissions control.

#### [🔼 Back to top](#github-actions)

---

### **Links and Commands**

```
git add remote https://vilislavkalenski@github.com/...
git remote set-url origin https://...@gutgub
git push --set-upstream origin main
```

- https://github.com/actions/cache
- https://github.com/actions/checkout
- https://github.com/marketplace/actions/checkout
- https://github.com/actions/runner-images/blob/main/images/linux/Ubuntu2204-Readme.md
- https://docs.github.com/en/actions/using-github-hosted-runners/about-github-hosted-runners/about-github-hosted-runners#supported-software

#### [🔼 Back to top](#github-actions)