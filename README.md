# DefinaHelper Smart Script

## Automatic mining
1. Automatic prospecting and mining. You can configure the type of mining to be mined according to your hero configuration, and the script will automatically select the best cost-effective hero combination for mining. For example, only a combination of S+3A will be sent to play S ore, and SS will not be wasted on S ore. (The script has made the greatest optimization in grabbing mines. As long as the system releases NPC mines, there is a 90% chance that this script will grab them)
2. Use of protective cover: configure whether to use protective cover according to the mine grade.
3. Evacuation without cover: whether to evacuate actively after the mine protection cover expires (especially suitable for S mine, the 3-hour protection cover provided by the system)
4. Automatic pledge after mining, and automatic harvest after 3 hours.

## Evil Mansion does the task automatically
1. Select the tasks that need to be automatically done by the script (31 tasks)
2. Configurable success rate, and the number of automatic refreshes per day. Brush to the designated task to do it.
3. The script automatically selects the best cost-effective hero combination to do the task (the hero combination is greater than the set success rate)
4. After the task is completed, you will receive the reward automatically.

## Adventure and Arena
1. Set the number of daily adventures and sweeps
2. Number of daily arena battles

## report
1. View the revenue statistics generated during the script running (displayed in a daily report).

## Other functions
1. Automatically receive mail rewards
2. Automatically receive daily tasks and weekly task rewards
3. The secret treasure chest will be automatically robbed
4. Information about script running can be notified by Telegram message in real time.



---

# update log
|Update time|Update function
|-|-
|2022-1-17 |1. The Evil Spirit Building has added an advanced configuration function, which allows you to set up designated hero groups to do designated tasks to avoid high-level heroes from doing low-level tasks.
|| 2. The mysterious treasure chest is modified to be automatically grabbed at 8:00 am and 8:00 pm
|2022-1-12 |1. The Evil Spirit Building is restored. The official update rules have changed a lot, please adjust the tasks to be done according to the actual success rate.
|2022-1-10 |1. Optimize the harvesting logic. When the protective cover expires + the possession time is greater than 3 hours, harvesting will be triggered, and then the mine will be evacuated and re-occupied. If the possession time is less than 3 hours, use the props to extend the protective cover.
|2022-1-8 |1. The game version is updated, and the update script is adapted to the latest game version.
|2022-1-2 |1. Add report function
|| 2. Optimized the update of the number of props, and fixed the problem that no props were still used, which caused the error code to be thrown all the time.
|2022-1-1 |1. Mining Settings - Harvest Evacuation: After the mine has been occupied for 3 hours and clicked on Harvest, if the mine does not have a protective cover or the protective cover is about to expire within 10 minutes, it will take the initiative to evacuate to avoid wasting the protective cover .
|| 2. Evil Mansion - Idle Task: The refresh operation is triggered only when the idle Evil Task is greater than the set value (to avoid when there is only one grid, only one grid will be refreshed, which increases the probability of brushing to the specified task )
||3. Other optimizations: When you have no physical strength, you will no longer perform tasks that require physical strength. You can stop the script, enter the game to replenish physical strength, and then start the script.
|2021-12-31 |1. The automatic opening of adventure missions, the number of daily adventure levels and the number of raids can be set
|| 2. The daily tasks of the arena are opened, and the number of victories in one day is set.
||3. The number of secret treasure chests to be grabbed at 8 o'clock every day (limited to 30).
|2021-12-30 |1. Parameters can be set, limited to only NPC mines
|| 2. Parameters can be set, the hero of the corresponding level can only play the mine of the corresponding level (for example: the SS hero does not play the S mine)
|2021-12-29 |Evil Mansion Mission Display