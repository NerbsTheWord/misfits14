## Misfits Chat Action Broadcasting — #Misfits Add
# Emote chat text broadcast for player interactions that normally only show as sprite popups.
# All strings are the action portion only; the emote system wraps them as: "* <name> <message> *"

## PointingChatSystem
pointing-chat-point-at-other = points at {$other}

## OfferItemSystem
# Broadcast when a player hands an item to another player after accepting an offer.
misfits-chat-offer-handoff = hands {$item} to {$target}

## CarryingSystem
# Broadcast when a player picks up or puts down another entity.
misfits-chat-carry-pickup = picks up {$carried}
misfits-chat-carry-drop = puts down {$carried}
misfits-chat-carry-throw = throws {$victim}
misfits-chat-double-grab-throw = hurls {$victim} across the room

## CuffingChatSystem
# Broadcast when a player successfully restrains another entity with handcuffs.
misfits-chat-cuff-applied = restrains {$target}
misfits-chat-cuff-self = restrains themselves

## FactionBankTerminalSystem
# Observable emote broadcast to bystanders when a player uses a terminal.
misfits-chat-terminal-use = uses the {$terminal} terminal

## PersistentCurrencySystem
# Private feedback (only to the player) for deposit/withdraw actions.
misfits-currency-no-currency = You're not holding any currency!
misfits-currency-deposited = Deposited {$amount} {$type}. Total: {$total}
misfits-currency-insufficient = Not enough currency!
misfits-currency-withdrew = Withdrew {$amount} {$type}.

## SpearBlockSystem
# Emote sent from the defender describing the block — "* Jane deflects John's spear... *"
spear-block-embedded-emote = deflects {$thrower}'s {$spear}, embedding it in their {$shield}
spear-block-deflected-emote = deflects {$thrower}'s {$spear}, sending it to the ground

