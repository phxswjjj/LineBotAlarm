# 目的
利用 LINE Notify 通知訊息

# 準備
申請 LINE Notify 與群組連動兩組權杖(Bearer)，利用這兩組設定的名稱區分 Error 及 Info

# 使用
1. 取代 [Program.cs > Bearer_XXX](LintBotAlarm/Program.cs#L9) 為 Info 權杖
1. 取代 [LineNotify.cs > CreateError > Bearer_XXX](LintBotAlarm/LineNotify.cs#L30) 為 Error 權杖
1. 取代 [LineNotify.cs > CreateInfo > Bearer_XXX](LintBotAlarm/LineNotify.cs#L35) 為 Info 權杖
