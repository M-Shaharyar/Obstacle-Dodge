# Obstacle-Dodge
![Demo](https://github.com/M-Shaharyar/Obstacle-Dodge/blob/main/Game%20Video/ObstacleDodge-gif.gif)

<h2>Overview</h2>
<p>Obstacle Dodge is an engaging Unity game where players must navigate a challenging environment while avoiding dynamically appearing obstacles. The game requires quick reflexes and strategic movement to evade obstacles that can pop out from anywhere. Additionally, if the player touches any boundary, the color of that wall changes, adding a visual cue to the gameplay.</p>

<h2>How to Play</h2>
<ul>
    <li>Use <strong>Arrow Keys</strong> or <strong>WASD</strong> to move the player around.</li>
    <li>Avoid obstacles that appear on the path.</li>
    <li>Some obstacles will drop from above after a delay, so be cautious.</li>
    <li>There are flying obstacles that chase the player.</li>
    <li>Touching a boundary wall will change its color.</li>
</ul>

<h2>Features</h2>
<ul>
    <li><strong>Dynamic Obstacle Mechanics:</strong> Different types of obstacles challenge the player in unique ways.</li>
    <li><strong>Gravity-Based Dropping Obstacles:</strong> Some obstacles are suspended in the air and drop after a certain time.</li>
    <li><strong>Chasing Obstacles:</strong> Some obstacles track the player's position and move toward them.</li>
    <li><strong>Wall Color Change on Collision:</strong> Boundaries change color upon contact.</li>
    <li><strong>Rotating Spinner Obstacles:</strong> Adds an additional layer of difficulty.</li>
</ul>

<h2>Scripts Used</h2>
<h3>1. Dropper.cs</h3>
<p>This script controls obstacles that initially remain invisible and drop after a specified timer. Uses <strong>Rigidbody</strong> to apply gravity after the timer expires.</p>

<h3>2. FlyAtPlayer.cs</h3>
<p>This script controls obstacles that actively fly towards the player's position. Uses <strong>Vector3.MoveTowards()</strong> to chase the player. The obstacle disappears when it reaches the player’s position.</p>

<h3>3. Player.cs</h3>
<p>Handles player movement using Unity’s <strong>Input.GetAxis()</strong> for smooth controls. Allows movement along the X and Z axes using keyboard inputs.</p>

<h3>4. ObjectHit.cs</h3>
<p>Changes the color of an object when the player collides with it. Uses Unity’s <strong>OnCollisionEnter()</strong> method to detect player interaction. Updates the material to a gray color when hit.</p>

<h3>5. Spinner.cs</h3>
<p>Rotates an obstacle along specified axes to create a moving challenge. Uses <strong>transform.Rotate()</strong> in the Update method to continuously rotate the object.</p>

<h2>Technologies & Tools Used</h2>
<ul>
    <li><strong>Game Engine:</strong> Unity</li>
    <li><strong>Programming Language:</strong> C#</li>
    <li><strong>Physics Engine:</strong> Unity’s Rigidbody system</li>
    <li><strong>Shaders & Materials:</strong> Universal Render Pipeline (URP) Shader for color changes</li>
</ul>

<h2>How to Run the Game</h2>
<ol>
    <li>Clone the repository:</li>
    <pre><code>git clone https://github.com/M-Shaharyar/Obstacle-Dodge.git</code></pre>
    <li>Open the project in Unity.</li>
    <li>Press the <strong>Play</strong> button in the Unity Editor.</li>
    <li>Use the movement keys to dodge obstacles and experience the game!</li>
</ol>

<h2>Future Enhancements</h2>
<ul>
    <li>Add a scoring system.</li>
    <li>Implement different levels with increasing difficulty.</li>
    <li>Improve UI elements such as start and game-over screens.</li>
    <li>Introduce power-ups for players to survive longer.</li>
</ul>

<h2>Contribution</h2>
<p>Feel free to fork the repository, make improvements, and submit a pull request. Contributions are always welcome!</p>

<h2>License</h2>
<p>This project is open-source and available under the <a href="LICENSE">MIT License</a>.</p>
