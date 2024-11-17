namespace VecApp

module Vec =
    type Vector

    val create : float -> float -> Vector           // Create a vector with x and y components
    val add : Vector -> Vector -> Vector             // Add two vectors
    val subtract : Vector -> Vector -> Vector        // Subtract one vector from another
    val dot : Vector -> Vector -> float              // Compute the dot product
    val length : Vector -> float                     // Compute the length of the vector
    val toString : Vector -> string                  // Convert vector to string for printing
