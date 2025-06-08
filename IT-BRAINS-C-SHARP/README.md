📌 Əsas Git komandaları və nə işə yarayırlar:
| Əmr                           | Təsviri                                                            |
| `git init`                    | Yeni Git repository (layihə) yaradır                               |
| `git status`                  | Hansı faylların dəyişdiyini və commit üçün hazır olduğunu göstərir |
| `git add .`                   | Bütün dəyişiklikləri commit üçün əlavə edir                        |
| `git commit -m "Mesaj"`       | Dəyişiklikləri saxlayır (versiya yaradır)                          |
| `git log`                     | Keçmiş commit-ləri göstərir                                        |
| `git diff`                    | Dəyişiklikləri (məzmun fərqlərini) göstərir                        |
| `git clone URL`               | GitHub-dan və ya başqa bir yerdən layihəni klonlayır               |
| `git remote add origin URL`   | Uzaq (remote) GitHub adresini əlavə edir                           |
| `git push origin master`      | Dəyişiklikləri GitHub-a göndərir                                   |
| `git pull`                    | Uzaq repository-dən son dəyişiklikləri çəkir                       |
| `git branch`                  | Mövcud branch-ları (budaqları) göstərir                            |
| `git checkout -b yeni_branch` | Yeni bir budaq (branch) yaradır və ora keçir                       |
| `git merge branch_adi`        | Başqa bir budaqla birləşdirir                                      |
| `git reset`                   | Dəyişiklikləri geri qaytarmaq üçün istifadə olunur                 |
| `git rm fayl`                 | Faylı silib Git-ə bildirir                                         |
| `git stash`                   | Dəyişiklikləri müvəqqəti saxlayır (sənədi "cebə qoyur")            |
✅ Sadə Git İş Axını (workflow):
git init                          # layihəni başlat
git add .                         # bütün faylları əlavə et
git commit -m "İlk commit"        # versiya mesajı ilə yadda saxla
git remote add origin <link>      # GitHub adresini əlavə et
git push -f origin master         # GitHub-a göndər
