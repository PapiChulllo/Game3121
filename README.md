# Game3121

**Educational Unity course / challenge project (Game3121)** based on Unity Learn–style **Challenge 3** content: a floating player, scrolling background, and obstacle/money spawns, with **Input System** wiring for the float action.

---

## What it contains

- `Challenge 3` scripts: player float/bounce/boundaries, move-left obstacles, repeating background, spawn manager, spin helper
- Generated `PlayerInputActions` for the float-up binding
- `Course Library` assets typical of Unity Create-With-Code / challenge packs

**Status / limitations:** **course / challenge work**, not an original commercial game. The repository currently includes a committed **`Library/`** folder (Editor cache) — large and machine-specific; normally should not be versioned. Unity **2022.3.45f1**. No automated tests; Play mode not re-verified in this documentation pass.

## Tech stack

| Area | What it uses |
|---|---|
| Engine | **Unity** `2022.3.45f1` |
| Input | **Input System** (`PlayerInputActions`) |
| Physics | Rigidbody float / bounce / gravity modifier |
| FX | Particle systems + AudioClips on the player controller |

## What's in the project

| System | Key files |
|---|---|
| Player float, boundaries, collisions, SFX/VFX | `Assets/Challenge 3/Scripts/PlayerControllerX.cs` |
| Input actions asset (generated C#) | `Assets/Challenge 3/PlayerInputActions/` |
| World scroll / spawn / spin | `MoveLeftX.cs`, `RepeatBackgroundX.cs`, `SpawnManagerX.cs`, `SpinObjectsX.cs` |
| Course art | `Assets/Course Library/` |

### Code / system highlights

- **`PlayerControllerX`:** enables Input System action `FloatUp`, applies impulse while not `gameOver`, clamps Y bounds, bounces at lower bound, plays explode/money/bounce feedback on collision tags.
- Challenge scripts follow the Unity Learn “X” naming pattern (course starter modifications).

## Scenes

Challenge scenes live under `Assets/Challenge 3/` / `Assets/Scenes/` as imported with the course content. Open the Challenge 3 play scene in the Editor (exact build-settings list may include course defaults).

## Third-party assets

| Asset | Notes |
|---|---|
| **Unity Course Library / Challenge 3** starter content | Models, materials, and starter scripts from the educational package |
| Authored / modified scripts | Primarily under `Assets/Challenge 3/Scripts/` and Input Actions |

## About this repository

**Labeled educational / course repository (Game3121).** Public under **PapiChulllo**. Portfolio value is course completion and Input System adaptation, not a from-scratch IP. Concern: committed `Library/` bloat.
